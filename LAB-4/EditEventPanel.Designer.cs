using System.ComponentModel;

namespace LAB_4;

partial class EditEventPanel
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEventPanel));
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.editEventButton = new System.Windows.Forms.Button();
        this.eventName = new System.Windows.Forms.TextBox();
        this.agendaField = new System.Windows.Forms.TextBox();
        this.eventDate = new System.Windows.Forms.DateTimePicker();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(26, 22);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(106, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Edytuj wydarzenie";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(26, 72);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(106, 20);
        this.label2.TabIndex = 1;
        this.label2.Text = "Nazwa wydarzenia:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(26, 107);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(106, 20);
        this.label3.TabIndex = 2;
        this.label3.Text = "Agenda:";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(26, 142);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(106, 20);
        this.label4.TabIndex = 3;
        this.label4.Text = "Termin wydarzenia:";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // editEventButton
        // 
        this.editEventButton.Location = new System.Drawing.Point(138, 185);
        this.editEventButton.Name = "editEventButton";
        this.editEventButton.Size = new System.Drawing.Size(200, 23);
        this.editEventButton.TabIndex = 4;
        this.editEventButton.Text = "Edytuj wydarzenie";
        this.editEventButton.UseVisualStyleBackColor = true;
        this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
        // 
        // eventName
        // 
        this.eventName.Location = new System.Drawing.Point(138, 73);
        this.eventName.Name = "eventName";
        this.eventName.Size = new System.Drawing.Size(199, 20);
        this.eventName.TabIndex = 5;
        // 
        // agendaField
        // 
        this.agendaField.Location = new System.Drawing.Point(138, 108);
        this.agendaField.Name = "agendaField";
        this.agendaField.Size = new System.Drawing.Size(199, 20);
        this.agendaField.TabIndex = 6;
        // 
        // eventDate
        // 
        this.eventDate.Location = new System.Drawing.Point(138, 142);
        this.eventDate.Name = "eventDate";
        this.eventDate.Size = new System.Drawing.Size(200, 20);
        this.eventDate.TabIndex = 7;
        // 
        // EditEventPanel
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(382, 226);
        this.Controls.Add(this.eventDate);
        this.Controls.Add(this.agendaField);
        this.Controls.Add(this.eventName);
        this.Controls.Add(this.editEventButton);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Name = "EditEventPanel";
        this.Text = "EditEventPanel";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button editEventButton;
    private System.Windows.Forms.TextBox eventName;
    private System.Windows.Forms.TextBox agendaField;
    private System.Windows.Forms.DateTimePicker eventDate;

    private System.Windows.Forms.Label label1;

    #endregion
}