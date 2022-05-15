using System;

namespace LAB_4;

public class Event
{
    private int _id;
    private String _name;
    private String _agenda;
    private String _date;

    public Event(int id, string name, string agenda, string date)
    {
        _id = id;
        _name = name;
        _agenda = agenda;
        _date = date;
    }

    public Event()
    {
    }

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Agenda
    {
        get => _agenda;
        set => _agenda = value;
    }

    public string Date
    {
        get => _date;
        set => _date = value;
    }
}