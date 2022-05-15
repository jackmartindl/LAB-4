using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LAB_4;

public partial class EventManagementPanel : Form
{
    private List<Event> _events;
    private DatabaseHandler _databaseHandler = new DatabaseHandler();
    public EventManagementPanel()
    {
        InitializeComponent();
        Text = "Zarządzanie wydarzeniami";
        LoadEvents();
    }

    private void addNewEvent_Click(object sender, EventArgs e)
    {
        var newEvent = new NewEventPanel();
        newEvent.ShowDialog();
        LoadEvents();
    }

    private void removeEvent_Click(object sender, EventArgs e)
    {
        if (eventList.SelectedIndex >= 0)
        {
            _databaseHandler.RemoveEvent(_events[eventList.SelectedIndex]);
            LoadEvents();
        }
    }

    private void editEvent_Click(object sender, EventArgs e)
    {
        if (eventList.SelectedIndex >= 0)
        {
            new EditEventPanel(_events[eventList.SelectedIndex]).ShowDialog();
            LoadEvents();
        }
    }

    private void LoadEvents()
    {
        eventList.Items.Clear();
        _events = _databaseHandler.GetEventsList();
        for (int i = 0; i < _events.Count; i++)
        {
            eventList.Items.Add(_events[i].Name);
        }
    }
}