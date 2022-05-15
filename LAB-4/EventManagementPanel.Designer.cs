using System.ComponentModel;

namespace LAB_4;

partial class EventManagementPanel
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManagementPanel));
        this.eventList = new System.Windows.Forms.ListBox();
        this.addNewEvent = new System.Windows.Forms.Button();
        this.removeEvent = new System.Windows.Forms.Button();
        this.editEvent = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // eventList
        // 
        this.eventList.FormattingEnabled = true;
        this.eventList.Location = new System.Drawing.Point(12, 12);
        this.eventList.Name = "eventList";
        this.eventList.Size = new System.Drawing.Size(318, 433);
        this.eventList.TabIndex = 0;
        // 
        // addNewEvent
        // 
        this.addNewEvent.Location = new System.Drawing.Point(336, 126);
        this.addNewEvent.Name = "addNewEvent";
        this.addNewEvent.Size = new System.Drawing.Size(171, 26);
        this.addNewEvent.TabIndex = 1;
        this.addNewEvent.Text = "Dodaj wydarzenie";
        this.addNewEvent.UseVisualStyleBackColor = true;
        this.addNewEvent.Click += new System.EventHandler(this.addNewEvent_Click);
        // 
        // removeEvent
        // 
        this.removeEvent.Location = new System.Drawing.Point(336, 173);
        this.removeEvent.Name = "removeEvent";
        this.removeEvent.Size = new System.Drawing.Size(171, 26);
        this.removeEvent.TabIndex = 2;
        this.removeEvent.Text = "Usuń wydarzenie";
        this.removeEvent.UseVisualStyleBackColor = true;
        this.removeEvent.Click += new System.EventHandler(this.removeEvent_Click);
        // 
        // editEvent
        // 
        this.editEvent.Location = new System.Drawing.Point(336, 221);
        this.editEvent.Name = "editEvent";
        this.editEvent.Size = new System.Drawing.Size(171, 26);
        this.editEvent.TabIndex = 3;
        this.editEvent.Text = "Zmodyfikuj wydarzenie";
        this.editEvent.UseVisualStyleBackColor = true;
        this.editEvent.Click += new System.EventHandler(this.editEvent_Click);
        // 
        // EventManagementPanel
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(519, 450);
        this.Controls.Add(this.editEvent);
        this.Controls.Add(this.removeEvent);
        this.Controls.Add(this.addNewEvent);
        this.Controls.Add(this.eventList);
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.Name = "EventManagementPanel";
        this.Text = "EventManagementPanel";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox eventList;
    private System.Windows.Forms.Button addNewEvent;
    private System.Windows.Forms.Button removeEvent;
    private System.Windows.Forms.Button editEvent;

    #endregion
}