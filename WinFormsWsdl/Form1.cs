using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
//using WinFormsWsdl.SFDC;

namespace WinFormsWsdl
{
    public partial class Form1 : Form
    {
        public static SforceService SfdcBinding = new SforceService();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }       


        private void button2_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string userName = "cloader@veeva.partner28.katalyst";
            string password = "katalyst1234buALlLvPSRjEaVvEv2B9FGZUk";

            LoginResult CurrentLoginResult = null;

            try
            {
                CurrentLoginResult = SfdcBinding.login(userName, password);
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                // This is likley to be caused by bad username or password
                SfdcBinding = null;
                throw (ex);
            }
            catch (Exception ex)
            {
                // This is something else, probably comminication
                SfdcBinding = null;
                throw (ex);
            }
            if (CurrentLoginResult != null)
            {
               lblstatus.Text = "Connected as: " + CurrentLoginResult.userInfo.userFullName;
            }
            else
            {
                lblstatus.Text = "Connection failed!";
            }

            SfdcBinding.Url = CurrentLoginResult.serverUrl;

            //Create a new session header object and set the session id to that returned by the login
            SfdcBinding.SessionHeaderValue = new SessionHeader();
            SfdcBinding.SessionHeaderValue.sessionId = CurrentLoginResult.sessionId;

            
        }

        private void queryCalls()
        {

            QueryResult queryResult = null;
            String SOQL = txtQuery.Text;
            try
            {
                queryResult = Form1.SfdcBinding.query(SOQL);

                if (queryResult.size > 0)
                {
                    //put some code in here to handle the records being returned
                    dataCallList.Items.Clear();

                    for (int i = 0; i < queryResult.size; i++)
                    {
                        Call2_vod__c call = (Call2_vod__c)queryResult.records[i];
                        dataCallList.Items.Add(new ListViewItem(new string[] { call.Id.ToString(), call.Name.ToString(), call.Entity_Display_Name_vod__c.ToString(), call.Detailed_Products_vod__c }));
                    }


                }
                else
                {
                    //put some code in here to handle no records being returned
                    MessageBox.Show("No records returned.");
                }
            }
            catch (Exception ex)
            {
                // This is something else, probably comminication
                MessageBox.Show(ex.Message);
            }

            


        }

        private void queryBtn_Click(object sender, EventArgs e)
        {
            queryCalls();
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            String[] ids = new String[dataCallList.SelectedItems.Count];
            for (int i = 0; i < dataCallList.SelectedItems.Count; i++)
            {
                ids[i] = dataCallList.SelectedItems[i].Text;
            }

            DeleteResult[] deleteResults = SfdcBinding.delete(ids);
            DeleteResult deleteResult = deleteResults[0];

            if (deleteResult.success)
            {
                MessageBox.Show("Record ID " + deleteResult.id + " deleted succesfully.");
                foreach (ListViewItem eachItem in dataCallList.SelectedItems)
                {
                    dataCallList.Items.Remove(eachItem);
                }                
            }
            else
            {
                MessageBox.Show("Delete failed");
            }


        }
    }
}
