using System;

namespace Projekt_Spritzgussproduktion
{
    public class Mitarbeiter

    {
    public int MitarbID
    {
        get { return MitarbID; }
        set { _MitarbID = value; }
    }
    private int _MitarbID;

    public string MitarbName
    {
        get { return MitarbName; }
        set { _MitarbName = value; }
    }

    private string _MitarbName;


    public string MitarbEmail
    {
        get { return MitarbEmail; }
        set { _MitarbEmail = value; }
    }

    private string _MitarbEmail;

    public string MitarbTel
    {
        get { return MitarbTel; }
        set { _MitarbTel = value; }
    }

    private string _MitarbTel;

    public string MitarbFTel
    {
        get { return MitarbFTel; }
        set { _MitarbFTel = value; }
    }

    private string _MitarbFTel;

    public string MitarbUName
    {
        get { return MitarbUName; }
        set { _MitarbUName = value; }
    }

    private string _MitarbUName;

    public string MitarbPasswd
    {
        get { return MitarbPasswd; }
        set { _MitarbPasswd = value; }
    }

    private string _MitarbPasswd;

    public int MitarbPos
    {
        get { return MitarbPos; }
        set { _MitarbPos = value; }
    }

    private int _MitarbPos;

    public int MitarbAbt
    {
        get { return MitarbAbt; }
        set { _MitarbAbt = value; }
    }

    private int _MitarbAbt;

    public Mitarbeiter()
    {

    }

    public Mitarbeiter(int ID) : this()
    {
        Mitarbeiter_Load(this, new EventArgs());
        _MitarbID = ID;
    }

    private void Mitarbeiter_Load(object sender, EventArgs e)
    {

    }
    
    public bool MitarbAbtConfirm(int ID)
    {
        bool MitarbAbtConfirm;
        return (MitarbAbt == ID ? true : false);
    }

    public void SetupLogin(object sender, EventArgs e)
    {
        SetupMitarbID();
        SetupMitarbAbt();
        SetupMitarbPos();
    }

    private int SetupMitarbID()
    {
        login log = new login();
        _MitarbID = log.userID;
        return _MitarbID;
    }
    private int SetupMitarbAbt()
    {
        login log = new login();
        _MitarbAbt = log.AbtID;
        return _MitarbAbt;
    }
    private int SetupMitarbPos()
    {
        login log = new login();
        _MitarbPos = log.PosID;
        return _MitarbPos;
    }


    public void Contains(int Arg, string CheckedItem)
    {
        int CheckedItemInt = 0;
        string CheckedItemString = null;
        decimal checkedItemDecimal = 0;

        try
        {
            CheckedItemInt = Convert.ToInt32(CheckedItem);
        }
        catch (Exception e)
        {
            CheckedItem = null;
        }

        try
        {
            CheckedItemString = CheckedItem.ToString();

        }
        catch (Exception e)
        {
            CheckedItem = null;
        }

        try
        {
            checkedItemDecimal = Convert.ToDecimal(CheckedItem);
        }
        catch (Exception e)
        {
            CheckedItem = null;
        }
    }
    }
}