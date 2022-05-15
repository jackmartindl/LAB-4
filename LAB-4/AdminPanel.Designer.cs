using System.ComponentModel;

namespace LAB_4;

partial class AdminPanel
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
        this.label1 = new System.Windows.Forms.Label();
        this.usersConfigButton = new System.Windows.Forms.Button();
        this.eventConfigButton = new System.Windows.Forms.Button();
        this.entryConfigButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(109, 23);
        this.label1.TabIndex = 0;
        this.label1.Text = "Panel administratora";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // usersConfigButton
        // 
        this.usersConfigButton.Location = new System.Drawing.Point(35, 114);
        this.usersConfigButton.Name = "usersConfigButton";
        this.usersConfigButton.Size = new System.Drawing.Size(171, 23);
        this.usersConfigButton.TabIndex = 1;
        this.usersConfigButton.Text = "Zarządzanie użytkownikami";
        this.usersConfigButton.UseVisualStyleBackColor = true;
        this.usersConfigButton.Click += new System.EventHandler(this.usersConfigButton_Click);
        // 
        // eventConfigButton
        // 
        this.eventConfigButton.Location = new System.Drawing.Point(35, 145);
        this.eventConfigButton.Name = "eventConfigButton";
        this.eventConfigButton.Size = new System.Drawing.Size(171, 23);
        this.eventConfigButton.TabIndex = 2;
        this.eventConfigButton.Text = "Zarządzanie wydarzeniami";
        this.eventConfigButton.UseVisualStyleBackColor = true;
        this.eventConfigButton.Click += new System.EventHandler(this.eventConfigButton_Click);
        // 
        // entryConfigButton
        // 
        this.entryConfigButton.Location = new System.Drawing.Point(35, 174);
        this.entryConfigButton.Name = "entryConfigButton";
        this.entryConfigButton.Size = new System.Drawing.Size(171, 23);
        this.entryConfigButton.TabIndex = 3;
        this.entryConfigButton.Text = "Zarządzanie zapisami";
        this.entryConfigButton.UseVisualStyleBackColor = true;
        this.entryConfigButton.Click += new System.EventHandler(this.entryConfigButton_Click);
        // 
        // AdminPanel
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(235, 265);
        this.Controls.Add(this.entryConfigButton);
        this.Controls.Add(this.eventConfigButton);
        this.Controls.Add(this.usersConfigButton);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Name = "AdminPanel";
        this.Text = "AdminPanel";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button usersConfigButton;
    private System.Windows.Forms.Button eventConfigButton;
    private System.Windows.Forms.Button entryConfigButton;

    private System.Windows.Forms.Label label1;

    #endregion
}