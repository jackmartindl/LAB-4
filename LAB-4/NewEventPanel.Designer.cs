using System.ComponentModel;

namespace LAB_4;

partial class NewEventPanel
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEventPanel));
        this.label1 = new System.Windows.Forms.Label();
        this.createEventButton = new System.Windows.Forms.Button();
        this.eventName = new System.Windows.Forms.TextBox();
        this.agendaField = new System.Windows.Forms.TextBox();
        this.eventDate = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(21, 51);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 20);
        this.label1.TabIndex = 0;
        this.label1.Text = "Nazwa wydarzenia:";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // createEventButton
        // 
        this.createEventButton.Location = new System.Drawing.Point(127, 162);
        this.createEventButton.Name = "createEventButton";
        this.createEventButton.Size = new System.Drawing.Size(233, 23);
        this.createEventButton.TabIndex = 1;
        this.createEventButton.Text = "Stwórz wydarzenie";
        this.createEventButton.UseVisualStyleBackColor = true;
        this.createEventButton.Click += new System.EventHandler(this.createEventButton_Click);
        // 
        // eventName
        // 
        this.eventName.Location = new System.Drawing.Point(127, 51);
        this.eventName.Name = "eventName";
        this.eventName.Size = new System.Drawing.Size(233, 20);
        this.eventName.TabIndex = 2;
        // 
        // agendaField
        // 
        this.agendaField.Location = new System.Drawing.Point(127, 88);
        this.agendaField.Name = "agendaField";
        this.agendaField.Size = new System.Drawing.Size(233, 20);
        this.agendaField.TabIndex = 5;
        // 
        // eventDate
        // 
        this.eventDate.Location = new System.Drawing.Point(127, 122);
        this.eventDate.Name = "eventDate";
        this.eventDate.Size = new System.Drawing.Size(233, 20);
        this.eventDate.TabIndex = 6;
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(21, 88);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(100, 20);
        this.label2.TabIndex = 7;
        this.label2.Text = "Agenda:";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(21, 122);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(100, 20);
        this.label3.TabIndex = 8;
        this.label3.Text = "Termin wydarzenia:";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(21, 25);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(263, 23);
        this.label4.TabIndex = 9;
        this.label4.Text = "Nowe wydarzenie";
        // 
        // NewEventPanel
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(412, 203);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.eventDate);
        this.Controls.Add(this.agendaField);
        this.Controls.Add(this.eventName);
        this.Controls.Add(this.createEventButton);
        this.Controls.Add(this.label1);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Name = "NewEventPanel";
        this.Text = "NewEventPanel";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button createEventButton;
    private System.Windows.Forms.TextBox eventName;
    private System.Windows.Forms.TextBox agendaField;
    private System.Windows.Forms.DateTimePicker eventDate;

    #endregion
}