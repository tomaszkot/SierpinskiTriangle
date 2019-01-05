namespace SierpinskiTriangle
{
  partial class SierpinskiTriangleForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.generatePointsBtn = new System.Windows.Forms.Button();
      this.pointsNumberEditor = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.pointsNumberEditor)).BeginInit();
      this.SuspendLayout();
      // 
      // generatePointsBtn
      // 
      this.generatePointsBtn.Location = new System.Drawing.Point(699, 12);
      this.generatePointsBtn.Name = "generatePointsBtn";
      this.generatePointsBtn.Size = new System.Drawing.Size(107, 23);
      this.generatePointsBtn.TabIndex = 0;
      this.generatePointsBtn.Text = "generate (n) points";
      this.generatePointsBtn.UseVisualStyleBackColor = true;
      this.generatePointsBtn.Click += new System.EventHandler(this.generatePointsBtn_Click);
      // 
      // pointsNumberEditor
      // 
      this.pointsNumberEditor.Location = new System.Drawing.Point(573, 15);
      this.pointsNumberEditor.Name = "pointsNumberEditor";
      this.pointsNumberEditor.Size = new System.Drawing.Size(120, 20);
      this.pointsNumberEditor.TabIndex = 1;
      this.pointsNumberEditor.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // SierpinskiTriangleForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(818, 761);
      this.Controls.Add(this.pointsNumberEditor);
      this.Controls.Add(this.generatePointsBtn);
      this.Name = "SierpinskiTriangleForm";
      this.Text = "SierpinskiTriangle";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      ((System.ComponentModel.ISupportInitialize)(this.pointsNumberEditor)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button generatePointsBtn;
    private System.Windows.Forms.NumericUpDown pointsNumberEditor;
  }
}

