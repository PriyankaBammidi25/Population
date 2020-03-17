function Validate()
{
    alert("hi");
    var flag = 0;
    var fname = document.getByElementById("txtfname").value;
    alert(name);
    var mname = document.getElementById("txtmname").value;
    var lname = document.getElementById("txtlname").value;
    var Regex = new Regex("[A-Za-z*'-]+");
    var fcheck = Regex.test(fname);
    var mcheck = Regex.test(mname);
    var lcheck = Regex.test(lname);
    var s1 = fname+" "+mname + " " + lname;
    if (!fcheck && !mcheck && !lcheck)
    {
        alert("enter only alphabets and * - '");
        flag = 1;
        
    }
    else if (s1.length > 32)
    {
        alert("Name should not be more than 32 characters");
        flag = 1;
    }
    var date = document.getElementById("txtDate").value;
    var Reg = new Reg("((0|1)[0-9]|2[0-9]|3[1-2])\/(0[1-9]|1[1-2])\/(190[0-9]|19[11-99]|200[0-9]|20[11-99])");
    var dtCurrent = new Date();
    var d1 = new Date(date);
    if (Reg.test(date))
    {
        var y1 = dtCurrent.getFullYear();
        var y2 = d1.getFullYear();
        var age = y1 - y2;
        if (age > 125)
        {
            alert("age should be less than 125")
            flag = 1;
        }
    }
    if (flag == 0)
        return true;
    else
        return false;

}