using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Web;

using System.Runtime.Serialization;
using Newtonsoft.Json;
using RestSharp;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;





namespace ConsumingMyService
{
    public partial class Form1 : Form
    {
        string BaseUrl = "http://localhost/TempleRestService/Service1.svc";
        public Form1()
        {
            InitializeComponent();
            //CreateColumns();
            

        }

      
        private void button1_Click(object sender, EventArgs e)
        {

            
           
        }
       

        public string RestCallGetToken(string uname , string password)
        {
            string _response = string.Empty;
            String urlString = String.Empty;
            try
            {

                urlString = String.Format("GetAccessToken?uname={0}&pass={1}", uname, password);
               
                RestClient obj = new RestClient(BaseUrl);
                var request = new RestRequest(urlString ,Method.GET);
                var response = obj.Execute(request);
                _response = response.Content;
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return _response;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string uname = String.Empty;
            string password = String.Empty;
            string ErrorMsg = String.Empty;
            string accessToken = String.Empty;
            try {
                uname = UnametextBox.Text;
                password = PasstextBox.Text;
                if (!String.IsNullOrEmpty(uname) && !String.IsNullOrEmpty(password))
                {
                    accessToken = RestCallGetToken(uname, password);
                    if (!String.IsNullOrEmpty(accessToken))
                    {
                        
                        textBox2.Text = "";
                        textBox2.Text = accessToken;
                    }
                }
                else
                {
                    ErrorMsg = "Please Enter User name and Password!";
                    MessageBox.Show(ErrorMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch(Exception  es){
            
            
            }
           
        }

        private void DevLstbutton2_Click(object sender, EventArgs e)
        {
            string token = String.Empty;
            string jsonStr = String.Empty;
            token=textBox1.Text;
            
            if (!String.IsNullOrEmpty(token))
            {
                jsonStr=RestCallGetLstOfDevotees(token);
                richTextBox1.Text = "";
                richTextBox1.Text = jsonStr;
            }
            else {
                //ErrorMsg = "Please Enter User name and Password!";
                MessageBox.Show("Enter Access Token", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string RestCallGetLstOfDevotees(string token)
        {
            string _response = string.Empty;
            String urlString = String.Empty;
            try
            {

                RestClient client = new RestClient(BaseUrl);
                // client.Authenticator = new HttpBasicAuthenticator(username, password);
                urlString = String.Format("GetListOfDevoters?accessToken={0}", token);
                var request = new RestRequest(urlString, Method.GET);
                var response = client.Execute(request);
                _response = response.Content; 

#region Comment
                //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
                //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource

                // easily add HTTP Headers
                // request.AddHeader("header", "value");

                // add files to upload (works with compatible verbs)
                //request.AddFile(path);

                // execute the request



                //urlString = String.Format("GetListOfDevoters?accessToken={0}", token);
                ////urlString = String.Format(BaseUrl + "/GetListOfDevoters?{0}",);
                //var uri = new Uri(urlString);
                //RestClient obj = new RestClient(BaseUrl);

                //var request = new RestRequest(uri);
                ////request.AddParameter("accessToken", token);
                //var response = obj.Execute(request);
                //_response = response.Content;
#endregion Comment
              
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return _response;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnametextBox.Text = "";
            PasstextBox.Text = "";

            textBox2.Text = "";
        }

       
    }
}
