using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace My_First_Game_1
{
    public class WinForm : System.Windows.Forms.Form
    {
        //Device Vairable
        private Device device;
        private System.ComponentModel.Container components = null;
        public WinForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);
        }
        //Hardware intiallizer Method
        public void InitializeDevice()
        {
            PresentParameters presentParams = new PresentParameters();
            presentParams.Windowed = true;
            presentParams.SwapEffect = SwapEffect.Discard;

            device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, presentParams);
        }

            protected override void OnPaint (System.Windows.Forms.PaintEventArgs e)
            {
                device.Transform.Projection = Matrix.PerspectiveFovLH((float)Math.PI / 4, this.Width / this.Height, 1f, 50f);
                device.Transform.View = Matrix.LookAtLH(new Vector3(0, 0, -30), new Vector3(0, 0, 0), new Vector3(0, 1, 0));
                device.RenderState.Lighting = false;
                device.RenderState.CullMode = Cull.None;
                //Vector itself
                CustomVertex.PositionColored[] vertices = new CustomVertex.PositionColored[3];
                vertices[0].Position = new Vector3(0f, 0f, 0f);
                vertices[0].Color = Color.Red.ToArgb();
                vertices[1].Position = new Vector3(10f, 0f, 0f);
                vertices[1].Color = Color.Green.ToArgb();
                vertices[2].Position = new Vector3(5f, 10f, 0f);
                vertices[2].Color = Color.Yellow.ToArgb();
                //Device Start
                device.Clear(ClearFlags.Target, Color.DarkSlateBlue, 1.0f,0);
                device.BeginScene();
                device.VertexFormat = CustomVertex.PositionColored.Format;
                device.VertexFormat = CustomVertex.TransformedColored.Format;
                device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices);
                device.EndScene();
                device.Present();
                this.Invalidate();
            }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
        }
        
        //Main Method
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run Application
            using (WinForm Directx1 = new WinForm())
            {
                //Hardware intiallizer
                Directx1.InitializeDevice();
                Application.Run(Directx1);
            }
        }
    }
}
