using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //on form closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appManager.loginForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //get patients data
            var patients = appManager.entities.patients;
            patientsGridView.Rows.Clear();
            foreach(var patient in patients)
            {
                patientsGridView.Rows.Add(patient.patient_name, patient.age, patient.mobile);
            }
        }
        
        #region patient group box
        private void patientsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //add patient's info to the form
            if (patientsGridView.SelectedRows[0].Cells[0].Value != null)
            {
                string patientName = patientsGridView.SelectedRows[0].Cells[0].Value.ToString();
                appManager.selectedPatient = appManager.entities.patients.Where(p => p.patient_name == patientName).FirstOrDefault();
                if (appManager.selectedPatient != null)
                {
                    idTextBox.Text = appManager.selectedPatient.patient_ID.ToString();
                    nameTextBox.Text = appManager.selectedPatient.patient_name;
                    ageTextBox.Text = appManager.selectedPatient.age.ToString();
                    mobileTextBox.Text = appManager.selectedPatient.mobile;
                    if (!appManager.selectedPatient.sex.Contains("female"))
                    {
                        male.Checked = true;
                        female.Checked = false;
                    }
                    else
                    {
                        male.Checked = false;
                        female.Checked = true;
                    }
                    //add the patient's visits info 
                    int pID = int.Parse(idTextBox.Text);
                    var visits = appManager.entities.visits.Where(v => v.patient_ID == pID);
                    visitsGridView.Rows.Clear();
                    visitIDTextBox.Text = "";
                    visitDate.Value = DateTime.Now;
                    visitComplaintTextBox.Text = "";
                    visitPulseTextBox.Text = "";
                    visitTempTextBox.Text = "";
                    visitBpTextBox.Text = "";
                    visitGeneralTextBox.Text = "";
                    visitDrugTextBox.Text = "";
                    visitFeesTextBox.Text = "";
                    foreach (var visit in visits)
                    {
                        visitsGridView.Rows.Add(visit.date.ToString("dd/MM/yyyy hh:mm tt"), visit.complaint, visit.visit_ID);
                    }
                }
            }
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(searchTextBox.Text != "")
                {
                    patientsGridView.Rows.Clear();
                    foreach (var p in appManager.entities.patients)
                    {
                        if (p.patient_name.Contains(searchTextBox.Text))
                        {
                            patientsGridView.Rows.Add(p.patient_name, p.age, p.mobile);
                        }
                    }
                }
                else
                {
                    MainForm_Load(null, null);
                }
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            var newPatient = new patient();
            newPatient.patient_name = nameTextBox.Text;
            newPatient.age = ageTextBox.Text == "" ? 0 : int.Parse(ageTextBox.Text);
            newPatient.mobile = mobileTextBox.Text;
            newPatient.sex = male.Checked == true ? "male" : "female";
            appManager.entities.patients.Add(newPatient);
            appManager.entities.SaveChanges();
            MainForm_Load(null, null);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idTextBox.Text);
            var newPatient = appManager.entities.patients.Where(p=>p.patient_ID == id).FirstOrDefault();
            if (newPatient != null)
            {
                newPatient.patient_name = nameTextBox.Text;
                newPatient.age = ageTextBox.Text == "" ? 0 :  int.Parse(ageTextBox.Text);
                newPatient.mobile = mobileTextBox.Text;
                newPatient.sex = male.Checked == true ? "male" : "female";
                appManager.entities.SaveChanges();
                MainForm_Load(null, null);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            appManager.confirmDlg = new ConfirmDialog("متأكد من حذف المريض\n" +
                $"{appManager.selectedPatient.patient_name}");
            DialogResult dlg = appManager.confirmDlg.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                int id = int.Parse(idTextBox.Text);
                var newPatient = appManager.entities.patients.Where(p => p.patient_ID == id).FirstOrDefault();
                if (newPatient != null)
                {
                    appManager.entities.patients.Remove(newPatient);
                    appManager.entities.SaveChanges();
                    MainForm_Load(null, null);
                }
            }
        }
        #endregion

        #region visit group box
        private void visitsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(visitsGridView.SelectedRows[0].Cells[0].Value != null)
            {
                string visitDatedb = visitsGridView.SelectedRows[0].Cells[0].Value.ToString();
                int visitid = int.Parse(visitsGridView.SelectedRows[0].Cells[2].Value.ToString());
                DateTime date = DateTime.Parse(visitDatedb);
                appManager.selectedVisit = appManager.entities.visits.Where(p => p.visit_ID == visitid).FirstOrDefault();
                if (appManager.selectedVisit != null)
                {
                    visitIDTextBox.Text = appManager.selectedVisit.visit_ID.ToString();
                    visitDate.Value = appManager.selectedVisit.date;
                    visitComplaintTextBox.Text = appManager.selectedVisit.complaint;
                    visitPulseTextBox.Text = appManager.selectedVisit.pulse;
                    visitTempTextBox.Text = appManager.selectedVisit.temp.ToString();
                    visitBpTextBox.Text = appManager.selectedVisit.bloodpressure;
                    visitGeneralTextBox.Text = appManager.selectedVisit.general;
                    visitDrugTextBox.Text = appManager.selectedVisit.drug;
                    visitFeesTextBox.Text = appManager.selectedVisit.fee.ToString();
                }
            }
        }

        private void insertVisitBtn_Click(object sender, EventArgs e)
        {
            visit newVisit = new visit();
            newVisit.date = DateTime.Parse(visitDate.Text);
            newVisit.complaint = visitComplaintTextBox.Text;
            newVisit.pulse = visitPulseTextBox.Text;
            newVisit.temp = visitTempTextBox.Text == ""? 0 : int.Parse(visitTempTextBox.Text);
            newVisit.bloodpressure = visitBpTextBox.Text;
            newVisit.general = visitGeneralTextBox.Text;
            newVisit.drug = visitDrugTextBox.Text;
            newVisit.fee = visitFeesTextBox.Text == "" ? 0 : int.Parse(visitFeesTextBox.Text);
            newVisit.patient_ID = appManager.selectedPatient.patient_ID;
            appManager.entities.visits.Add(newVisit);
            appManager.entities.SaveChanges();
            visitsGridView.Rows.Clear();
            int pID = int.Parse(idTextBox.Text);
            var visits = appManager.entities.visits.Where(v => v.patient_ID == pID);
            //update the grid view
            visitsGridView.Rows.Clear();
            foreach (var visit in visits)
            {
                visitsGridView.Rows.Add(visit.date.ToString(), visit.complaint, visit.visit_ID);
            }
        }

        private void updateVisitBtn_Click(object sender, EventArgs e)
        {
            if (visitIDTextBox.Text == "")
            {
                MessageBox.Show("من فضلك إختار زيارة");
            }
            else
            {
                int id = int.Parse(visitIDTextBox.Text);
                visit newVisit = appManager.entities.visits.Where(p => p.visit_ID == id).FirstOrDefault();
                if (newVisit != null)
                {
                    newVisit.date = DateTime.Parse(visitDate.Text);
                    newVisit.complaint = visitComplaintTextBox.Text;
                    newVisit.pulse = visitPulseTextBox.Text;
                    newVisit.temp = visitTempTextBox.Text == "" ? 0 : int.Parse(visitTempTextBox.Text);
                    newVisit.bloodpressure = visitBpTextBox.Text;
                    newVisit.general = visitGeneralTextBox.Text;
                    newVisit.drug = visitDrugTextBox.Text;
                    newVisit.fee = visitFeesTextBox.Text == "" ? 0 : int.Parse(visitFeesTextBox.Text);
                    newVisit.patient_ID = appManager.selectedPatient.patient_ID;
                    appManager.entities.SaveChanges();
                    //update the grid view
                    int pID = int.Parse(idTextBox.Text);
                    var visits = appManager.entities.visits.Where(v => v.patient_ID == pID);
                    visitsGridView.Rows.Clear();
                    foreach (var visit in visits)
                    {
                        visitsGridView.Rows.Add(visit.date.ToString(), visit.complaint, visit.visit_ID);
                    }
                }
            }
        }

        private void deleteVisitBtn_Click(object sender, EventArgs e)
        {
            appManager.confirmDlg = new ConfirmDialog($"متأكد من حذف زيارة \n {appManager.selectedPatient.patient_name} \n بتاريخ {appManager.selectedVisit.date.ToString("dd / MM / yyyy")}");
            DialogResult dlg = appManager.confirmDlg.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                int id = int.Parse(visitIDTextBox.Text);
                var newPatient = appManager.entities.visits.Where(p => p.visit_ID == id).FirstOrDefault();
                if (newPatient != null)
                {
                    appManager.entities.visits.Remove(newPatient);
                    appManager.entities.SaveChanges();
                    //update the grid view
                    int pID = int.Parse(idTextBox.Text);
                    var visits = appManager.entities.visits.Where(v => v.patient_ID == pID);
                    visitsGridView.Rows.Clear();
                    foreach (var visit in visits)
                    {
                        visitsGridView.Rows.Add(visit.date.ToString(), visit.complaint, visit.visit_ID);
                    }
                    MainForm_Load(null, null);
                }
            }
        }
        #endregion
    }
}
