using System;
using System.Drawing;
using System.Windows.Forms;

namespace SierpinskiTriangle
{
  public partial class SierpinskiTriangleForm : Form
  {

    SierpinskiTriangleLogic logic = new SierpinskiTriangleLogic();

    public SierpinskiTriangleForm()
    {
      InitializeComponent();
    }
    
    private void generatePointsBtn_Click(object sender, EventArgs e)
    {
      logic.GeneratePointsSet((int)this.pointsNumberEditor.Value);
      Invalidate();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      foreach (var pt in logic.AllPoints)
        e.Graphics.FillRectangle(Brushes.Black, pt.X, pt.Y, 10, 10);
    }
  }
}
