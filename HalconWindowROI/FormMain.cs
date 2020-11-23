using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;
using ViewROI;

namespace HalconWindowROI
{
    public partial class FormMain : Form
    {
        HWndCtrl _viewCtrl;
        ROIController _roiCtrl;
        HImage hImage;
        public FormMain()
        {
            InitializeComponent();

<<<<<<< HEAD
         
=======
            _viewCtrl = new HWndCtrl(hWindowControl1);
            _roiCtrl = new ROIController();
            _viewCtrl.useROIController(_roiCtrl);
>>>>>>> 03798f184e99b3c42379e3f69136cce3c250666b


        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.RestoreDirectory = true;
            dialog.Multiselect = false;
            dialog.Filter = "图片|*.*";
            dialog.Title = "选择一张图片";
            DialogResult result =  dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                hImage = new HImage(dialog.FileName);
                _viewCtrl.addIconicVar(hImage); 
<<<<<<< HEAD
                //_viewCtrl.resetWindow();
                //_viewCtrl.repaint();
=======
                _viewCtrl.resetWindow();
                _viewCtrl.repaint();
>>>>>>> 03798f184e99b3c42379e3f69136cce3c250666b
                _viewCtrl.setViewState(HWndCtrl.MODE_VIEW_ZOOM_Wheel);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            _viewCtrl = new HWndCtrl(hWindowControl1);
            _roiCtrl = new ROIController();
            _viewCtrl.useROIController(_roiCtrl);
=======
>>>>>>> 03798f184e99b3c42379e3f69136cce3c250666b
            _roiCtrl.viewController.viewPort.HMouseMove += ViewPort_HMouseMove; ;
        }

        private void ViewPort_HMouseMove(object sender, HMouseEventArgs e)
        {
            var roi = _roiCtrl.getActiveROI();
            if (roi == null) return;
     
            for (var i = 0; i < roi.getModelDataName().Length; i++)
            {

                Debug.WriteLine($"{roi.getModelDataName()[i].S} : {roi.getModelData()[i].D}");
            }
        }

        private void btnDrawRect1_Click(object sender, EventArgs e)
        {
            ROIRectangle1 rect1 = new ROIRectangle1();
            _roiCtrl.setROIShape(rect1);
            
        }

        
        private void btnDrawRect2_Click(object sender, EventArgs e)
        {
            ROIRectangle2 rect2 = new ROIRectangle2();
            _roiCtrl.setROIShape(rect2);
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            ROICircle circle = new ROICircle();
            _roiCtrl.setROIShape(circle);
        }
    }
}
