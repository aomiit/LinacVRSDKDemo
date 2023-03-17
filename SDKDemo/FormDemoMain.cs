using Chica.VR.UEInterface.Comm;
using Chica.VR.UEInterface.Control;
using Chica.VR.UEInterface.Entities;
using System;
using System.Windows.Forms;

namespace SDKDemo
{
    public partial class FormDemoMain : Form
    {
        public FormDemoMain()
        {
            InitializeComponent();
        }

        private void FormDemoMain_Load(object sender, EventArgs e)
        {
            TopPack.TCPCOMM = true;

            if (TopPack.TCPCOMM)
            {
                TCPClientHelper.Instance.Init();
            }

            Accelerator.Instance.Init();
        }

        private void FormDemoMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Accelerator.Instance.Free();
            if (TopPack.TCPCOMM)
                TCPClientHelper.Instance.Close();
        }

        private void nmGantryAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                try
                {
                    Accelerator.Instance.RotateGantry(nmGantryAngle.Value, 12.0M);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nmCollAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                try
                {
                    Accelerator.Instance.RotateColl(nmCollAngle.Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void numX1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Accelerator.Instance.SetJaw(numX1.Value, numX2.Value, numY1.Value, numY2.Value);
        }

        private void numX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\r'))
            {
                try
                {
                    Accelerator.Instance.JawX1 = numX1.Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void nmCouchVrt_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Accelerator.Instance.CurVrt = (double)(nmCouchVrt.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nmCouchLng_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Accelerator.Instance.CurLng = (double)(nmCouchLng.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nmCouchLat_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Accelerator.Instance.CurLat = (double)(nmCouchLat.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nmCouchAngle_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                Accelerator.Instance.CurCouchAngle = (double)nmCouchAngle.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBoard_Click(object sender, EventArgs e)
        {
            Accelerator.Instance.SwitchBoard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlMLC cMLC = new ControlMLC();

            decimal Jaw1 = 200;

            string LeafX1 = "";
            string LeafX2 = "";

            for (int i = 0; i < 1; i++)
            {
                LeafX1 += "-100,";
            }

            for (int i = 1; i < 60; i++)
            {
                LeafX1 += "-150,";
            }

            for (int i = 60; i < 61; i++)
            {
                LeafX2 += "-100,";
            }
            for (int i = 61; i < 120; i++)
            {
                LeafX2 += "100,";
            }

            LeafX1 = LeafX1.Substring(0, LeafX1.Length - 1);
            LeafX2 = LeafX2.Substring(0, LeafX2.Length - 1);
            LeafX1 = "|[" + LeafX1 + "]|";
            LeafX2 = "|[" + LeafX2 + "]|";

            cMLC.BankX1 = LeafX1;
            cMLC.BankX2 = LeafX2;

            Accelerator.Instance.SetJaw(Jaw1, Jaw1, Jaw1, Jaw1);
            Accelerator.Instance.MLCOn(cMLC);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlMVRay mvbeam = new ControlMVRay();

            //"BeamOn","BeamOff"
            mvbeam.Action = "On";
            // "Ray" XRay "LightArea" light
            mvbeam.RayColor = "|[1,0,0]|";

            Accelerator.Instance.BeamOn(mvbeam);
        }

        private void buttonBeamOff_Click(object sender, EventArgs e)
        {
            Accelerator.Instance.BeamOff();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Accelerator.Instance.SwitchFiledLight();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            Accelerator.Instance.QueryStatus();

            System.Threading.Thread.Sleep(100);

            AcceleratorState obj = Accelerator.Instance.GetLinacStatus();

            if (obj != null)
            {
                gantryPlan.Text = obj.gantryAngle.ToString();
                collPlan.Text = obj.collAngle.ToString();
                vrtPlan.Text = obj.curVrt.ToString();

                labelStatus.Text = obj.Busying ? "运动中" : "空闲";
            }
        }
    }
}
