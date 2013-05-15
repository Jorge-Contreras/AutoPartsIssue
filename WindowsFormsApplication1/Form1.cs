using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolCribData;
using System.Threading;
using System.Timers;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private System.Timers.Timer Timer1;
        private int Counter;
        private int errorCounter = 0;
        private GeneralTablesEntities db;
        private Transactions_Not_Entered CurrentPart;
        private List<Transactions_Not_Entered> AllPendingTransactions;
        private List<Manual_Entry_Transactions> AllManualTransactions;

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://intranet.dartcontainer.com/ToolCribInventory/Pages/Inventory.aspx");
            Counter = 0;
            db = new GeneralTablesEntities();
            AllPendingTransactions = db.GetAllTransactions();
            AllManualTransactions = db.GetAllManualTransactions();
            //CurrentPart = db.GetNextPartToUpdate();
            CurrentPart = AllPendingTransactions.OrderBy(y => y.PartNumber).FirstOrDefault();
            BindMyList();
        }

        void OnTimer1Event(object source, ElapsedEventArgs e) //Timer Event
        {
            Timer1.Stop();
            System.Diagnostics.Debug.WriteLine("counter:" + Counter);
            System.Diagnostics.Debug.WriteLine("Error:" + errorCounter);
            if (errorCounter > 3)
            {
                Timer1.Stop();
                MessageBox.Show("Error");
                return;
            }
            switch (Counter)
            {
                case 0:
                    PressThisButton(NewIssue_Btn);
                    break;
                case 1:
                    PressThisButton(Attendant_Btn);
                    break;
                case 2:
                    PressThisButton(InsertNewDetail_btn);
                    break;
                case 3:
                    PressThisButton(UpdatePartField_btn);
                    break;
                case 4:
                    PressThisButton(SelectPart_Btn);
                    break;
                case 5:
                    PressThisButton(EquipmentField_btn);
                    break;
                case 6:
                    PressThisButton(SelectFromList_btn);
                    break;
                case 7:
                    PressThisButton(DateQty_btn);
                    Counter++;
                    break;
                case 8:
                    PressThisButton(GetPrice_btn);
                    break;
                case 9:
                    PressThisButton(InsertIssue_btn);
                    break;
                case 10:
                    PressThisButton(Finish_btn);
                    break;
            }
        }

        #region BUTTONS

        private void Automation_Btn_Click(object sender, EventArgs e)
        {
            if (db.Transactions_Not_Entered.Count() == 0) { return; }
            //Status_lbl.Text = "Initializing...";
            Timer1 = new System.Timers.Timer(3000);
            Timer1.Elapsed += new ElapsedEventHandler(OnTimer1Event);
            Timer1.Interval = 3000;
            Timer1.Enabled = true;
            CurrentPart = AllPendingTransactions.OrderBy(y => y.PartNumber).FirstOrDefault();
        }

        private void NewIssue_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_lnkNewOrder").InvokeMember("click");
                Status_lbl.Text = "Clicking New Issue.....";
                Counter++;
            }
            catch (Exception)
            {
                errorCounter++;
            }

            finally
            {
                Timer1.Start();
            }
        }

        private void Attendant_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrder_txtEmployeeListInsert").SetAttribute("value", "Luz Lomeli");
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrder_asmEmployeeListInsert_hdnSelectedValue").SetAttribute("value", "16468"); //Hidden Field 
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrder_txtOrderDateInsert").SetAttribute("value", DateTime.Today.ToShortDateString());
                var MyLink = webBrowser1.Document.Links.OfType<HtmlElement>().Where(a => a.GetAttribute("innerHTML") == "Insert");
                MyLink.FirstOrDefault().InvokeMember("Click");
                Status_lbl.Text = "Updating Attendant Info.....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }


        }

        private void InsertNewDetail_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var MyLink = webBrowser1.Document.Links.OfType<HtmlElement>().Where(a => a.GetAttribute("innerHTML") == "Insert New Detail");
                MyLink.FirstOrDefault().InvokeMember("Click");
                Status_lbl.Text = "Clicking InsertNewDetail......";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }

        }

        private void UpdatePartField_btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrderDetail_txtPartsListInsert").Focus();
                SendKeys.Send(CurrentPart.PartNumber);
                Status_lbl.Text = "Updating Part Field....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }
        }

        private void SelectPart_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Status_lbl.Text = "Selecting Option......";
                var MyLink2 = webBrowser1.Document.GetElementsByTagName("div");
                foreach (HtmlElement div in MyLink2)
                {

                    if (div.GetAttribute("className") == "asmMenuItem") //The Parent Element is asmMenu
                    {
                        if (div.GetAttribute("innerText").Contains("BLDG A"))   //Only select the items for a especific building
                        {
                            div.InvokeMember("Click");
                        }
                    }
                }
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }
        }

        private void EquipmentField_btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrderDetail_txtEquipmentListInsert").Focus();
                SendKeys.Send(CurrentPart.Department);
                Status_lbl.Text = "Typing Department....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }
        }

        private void SelectFromList_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Status_lbl.Text = "Selecting Option....";
                var MyLink2 = webBrowser1.Document.GetElementsByTagName("div");
                foreach (HtmlElement div in MyLink2)
                {

                    if (div.Parent.Id == "ctl00_ContentPlaceHolder1_dvwOrderDetail_asmEquipmentListInsert") //this will check that the element is contained in the equipment list to prevent a click on the Part asmMenu list
                    {
                        if (div.GetAttribute("className") == "asmMenuItem")
                        {
                            div.InvokeMember("Click");
                        }
                    }
                }
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }


        }

        private void DateQty_btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrderDetail_txtIssueDateInsert").SetAttribute("value", DateTime.Today.ToShortDateString());
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrderDetail_txtIssueQtyInsert").SetAttribute("value", CurrentPart.Qty);
                Status_lbl.Text = "Updating Date and Qty....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }
        }

        private void GetPrice_btn_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_dvwOrderDetail_btnGetIssuePriceInsert").InvokeMember("click");

                for (int i = 0; i < 40000; i++)  //delay to let the button return the ajax data.
                {

                }

                Status_lbl.Text = "Clicking Get Price....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }

        }

        private void InsertIssue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var MyLink = webBrowser1.Document.Links.OfType<HtmlElement>().Where(a => a.GetAttribute("innerHTML") == "Insert");
                MyLink.FirstOrDefault().InvokeMember("Click");
                Status_lbl.Text = "Clicking Insert....";
                Counter++;
                errorCounter = 0;
            }
            catch (Exception)
            {
                errorCounter++;
            }
            finally
            {
                Timer1.Start();
            }
        }

        private void Finish_btn_Click(object sender, EventArgs e)
        {
            Status_lbl.Text = "Checking for errors and next Transaction....";
            try
            {

                var errorText = webBrowser1.Document.GetElementById("ctl00_ContentPlaceHolder1_ucTitle_lblErrors"); //Try to get the error box, if it does not exits it will throw error.
                var MyLink = webBrowser1.Document.Links.OfType<HtmlElement>().Where(a => a.GetAttribute("innerHTML") == "Cancel"); //Get the Cancel Button
                MyLink.FirstOrDefault().InvokeMember("Click");
                db.PartError(CurrentPart.TranDetailID);
                AllPendingTransactions.Remove(CurrentPart);
                Status_lbl.Text = "cancel Clicked.....";
                BindMyList();
                if (db.CheckIfZero())
                {
                    Status_lbl.Text = "------ ALL TRANSACTIONS PROCESSED -----";
                    BindMyList();
                    Timer1.Stop();
                    Counter = 0;
                    return;
                }

                CurrentPart = AllPendingTransactions.OrderBy(y => y.PartNumber).FirstOrDefault();   //get Next Part From Local Transaction List


            }
            catch (Exception)
            {
                db.PartUpdated(CurrentPart.TranDetailID);
                AllPendingTransactions.Remove(CurrentPart);
                if (this.CheckifZero())
                {
                    Status_lbl.Text = "------ ALL TRANSACTIONS PROCESSED -----";
                    BindMyList();
                    Counter = 0;
                    Timer1.Stop();
                    return;
                }
                Counter = 2;
                CurrentPart = AllPendingTransactions.OrderBy(y => y.PartNumber).FirstOrDefault();
                BindMyList();
            }

            finally
            {
                Timer1.Start();
            }

        }

        private void ManualUpdate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                db.PartUpdated((Guid)ManualUpdate_lst.SelectedValue);
                BindMyList();
            }
            catch (Exception ex)
            {
                Status_lbl.Text = ex.InnerException.ToString();
            }
        }

        #endregion
        
        #region METHODS

        delegate void delPressButton(Button btn); //delagate to validate buttons on a different thread

        private void PressThisButton(Button btn)
        {

            if (btn.InvokeRequired)
            {
                delPressButton callBackMethod = new delPressButton(PressThisButton);
                this.Invoke(callBackMethod, btn);
            }
            else
            {
                btn.PerformClick();
            }
        }

        private void BindMyList()
        {
            var ManualEntries = db.GetAllManualEntry();

            PendingList.DataSource = null;
            PendingList.DataSource = db.GetAllPendingTransactions();
            PendingList.DisplayMember = "Description";

            ManualUpdate_lst.DataSource = new BindingSource(ManualEntries, null);
            ManualUpdate_lst.DisplayMember = "Value";
            ManualUpdate_lst.ValueMember = "Key";
        }

        private List<String> GetPendingTransactions()
        {
            var returnDic = new List<String>();
            var ManualEntryCount = AllPendingTransactions.Count();
            if (ManualEntryCount == 0)
            {
                returnDic.Add("No Pending Transactions");

            }
            else
            {
                returnDic = this.AllPendingTransactions.OrderBy(y => y.PartNumber).Select(x => x.Qty + " -- " + x.PartNumber + "--" + x.Description).ToList();
            }

            return returnDic;

        }

        private bool CheckifZero()
        {
            if (this.AllPendingTransactions.Count() == 0) { return true; } else { return false; }
        }

        #endregion
    }
}
