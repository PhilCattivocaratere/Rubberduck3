﻿using System.CodeDom;

namespace Rubberduck.InternalApi.Model;

public static class Tokens
{
    public const string Abs = "Abs";
    public const string AddressOf = "AddressOf";
    public const string And = "And";
    public const string Any = "Any";
    public const string As = "As";
    public const string Asc = "Asc";
    public const string Attribute = "Attribute";
    public const string Base = "Base";
    public const string Beep = "Beep";
    public const string Binary = "Binary";
    public const string Boolean = "Boolean";
    public const string ByRef = "ByRef";
    public const string Byte = "Byte";
    public const string ByVal = "ByVal";
    public const string Call = "Call";
    public const string Case = "Case";
    public const string CBool = "CBool";
    public const string CByte = "CByte";
    public const string CCur = "CCur";
    public const string CDate = "CDate";
    public const string CDbl = "CDbl";
    public const string CDec = "CDec";
    public const string ChDir = "ChDir";
    public const string ChDrive = "ChDrive";
    public const string Chr = "Chr";
    public const string ChrB = "ChrB";
    public const string ChrW = "ChrW";
    public const string CInt = "CInt";
    public const string CLng = "CLng";
    public const string CLngLng = "CLngLng";
    public const string CLngPtr = "CLngPtr";
    public const string Close = "Close";
    public const string Command = "Command";
    public const string CommentMarker = "'";
    public const string Compare = "Compare";
    public const string Const = "Const";
    public const string Cos = "Cos";
    public const string CSng = "CSng";
    public const string CStr = "CStr";
    public const string CurDir = "CurDir";
    public const string Currency = "Currency";
    public const string CVar = "CVar";
    public const string CVErr = "CVErr";
    public const string Data = "Data";
    public const string Date = "Date";
    public const string DateValue = "DateValue";
    public const string Day = "Day";
    public const string Debug = "Debug";
    public const string Decimal = "Decimal";
    public const string Declare = "Declare";
    public const string DefBool = "DefBool";
    public const string DefByte = "DefByte";
    public const string DefCur = "DefCur";
    public const string DefDate = "DefDate";
    public const string DefDbl = "DefDbl";
    public const string DefInt = "DefInt";
    public const string DefLng = "DefLng";
    public const string DefLngLng = "DefLngLng";
    public const string DefLngPtr = "DefLngptr";
    public const string DefObj = "DefObj";
    public const string DefSng = "DefSng";
    public const string DefStr = "DefStr";
    public const string DefVar = "DefVar";
    public const string Dim = "Dim";
    public const string Dir = "Dir";
    public const string Do = "Do";
    public const string DoEvents = "DoEvents";
    public const string Double = "Double";
    public const string Each = "Each";
    public const string Else = "Else";
    public const string ElseIf = "ElseIf";
    public const string Empty = "Empty";
    public const string End = "End";
    public const string Enum = "Enum";
    public const string Environ = "Environ";
    public const string EOF = "EOF";
    public const string Eqv = "Eqv";
    public const string Erase = "Erase";
    public const string Err = "Err";
    public const string Error = "Error";
    public const string Event = "Event";
    public const string Exit = "Exit";
    public const string Exp = "Exp";
    public const string Explicit = "Explicit";
    public const string False = "False";
    public const string Fix = "Fix";
    public const string For = "For";
    public const string Format = "Format";
    public const string FreeFile = "FreeFile";
    public const string Friend = "Friend";
    public const string Function = "Function";
    public const string Get = "Get";
    public const string Global = "Global";
    public const string GoSub = "GoSub";
    public const string GoTo = "GoTo";
    public const string Hex = "Hex";
    public const string Hour = "Hour";
    public const string If = "If";
    public const string Imp = "Imp";
    public const string Implements = "Implements";
    public const string In = "In";
    public const string Input = "Input";
    public const string InputB = "InputB";
    public const string InputBox = "InputBox";
    public const string InStr = "InStr";
    public const string Int = "Int";
    public const string Integer = "Integer";
    public const string Is = "Is";
    public const string IsDate = "IsDate";
    public const string IsEmpty = "IsEmpty";
    public const string IsNull = "IsNull";
    public const string IsNumeric = "IsNumeric";
    public const string Join = "Join";
    public const string Kill = "Kill";
    public const string LBound = "LBound";
    public const string LCase = "LCase";
    public const string Left = "Left";
    public const string LeftB = "LeftB";
    public const string Len = "Len";
    public const string LenB = "LenB";
    public const string Let = "Let";
    public const string Like = "Like";
    public const string Line = "Line";
    public const string LineContinuation = " _";
    public const string Lock = "Lock";
    public const string LOF = "LOF";
    public const string Long = "Long";
    public const string LongLong = "LongLong";
    public const string LongPtr = "LongPtr";
    public const string Loop = "Loop";
    public const string LSet = "LSet";
    public const string LTrim = "LTrim";
    public const string Me = "Me";
    public const string Mid = "Mid";
    public const string MidB = "MidB";
    public const string Minute = "Minute";
    public const string MkDir = "MkDir";
    public const string Mod = "Mod";
    public const string Month = "Month";
    public const string MsgBox = "MsgBox";
    public const string New = "New";
    public const string Next = "Next";
    public const string Not = "Not";
    public const string Nothing = "Nothing";
    public const string Now = "Now";
    public const string Null = "Null";
    public const string Object = "Object";
    public const string Oct = "Oct";
    public const string On = "On";
    public const string Open = "Open";
    public const string Option = "Option";
    public const string Optional = "Optional";
    public const string Or = "Or";
    public const string Output = "Output";
    public const string ParamArray = "ParamArray";
    public const string Preserve = "Preserve";
    public const string Print = "Print";
    public const string Private = "Private";
    public const string Property = "Property";
    public const string Public = "Public";
    public const string Put = "Put";
    public const string RaiseEvent = "RaiseEvent";
    public const string Random = "Random";
    public const string Randomize = "Randomize";
    public const string Read = "Read";
    public const string ReDim = "ReDim";
    public const string Rem = "Rem";
    public const string Resume = "Resume";
    public const string Return = "Return";
    public const string RSet = "RSet";
    public const string Right = "Right";
    public const string RightB = "RightB";
    public const string RmDir = "RmDir";
    public const string Rnd = "Rnd";
    public const string RTrim = "RTrim";
    public const string Second = "Second";
    public const string Seek = "Seek";
    public const string Select = "Select";
    public const string Set = "Set";
    public const string Shared = "Shared";
    public const string Shell = "Shell";
    public const string Sin = "Sin";
    public const string Single = "Single";
    public const string Sng = "Sng";
    public const string Space = "Space";
    public const string Spc = "Spc";
    public const string Split = "Split";
    public const string Sqr = "Sqr";
    public const string Static = "Static";
    public const string Step = "Step";
    public const string Stop = "Stop";
    public const string Str = "Str";
    public const string StrConv = "StrConv";
    public const string String = "String";
    public const string StrPtr = "StrPtr";
    public const string Sub = "Sub";
    public const string Then = "Then";
    public const string Time = "Time";
    public const string To = "To";
    public const string Trim = "Trim";
    public const string True = "True";
    public const string Type = "Type";
    public const string TypeName = "TypeName";
    public const string TypeOf = "TypeOf";
    public const string UBound = "UBound";
    public const string UCase = "UCase";
    public const string Unlock = "Unlock";
    public const string Until = "Until";
    public const string Val = "Val";
    public const string Variant = "Variant";
    public const string vbBack = "vbBack";
    public const string vbCr = "vbCr";
    public const string vbCrLf = "vbCrLf";
    public const string vbEmpty = "vbEmpty";
    public const string vbFormFeed = "vbFormFeed";
    public const string vbLf = "vbLf";
    public const string vbNewLine = "vbNewLine";
    public const string vbNullChar = "vbNullChar";
    public const string vbNullString = "vbNullString";
    public const string vbTab = "vbTab";
    public const string vbVerticalTab = "vbVerticalTab";
    public const string WeekDay = "WeekDay";
    public const string Wend = "Wend";
    public const string While = "While";
    public const string Width = "Width";
    public const string With = "With";
    public const string WithEvents = "WithEvents";
    public const string Write = "Write";
    public const string XOr = "Xor";
    public const string Year = "Year";

    public const string EndSub = $"{End} {Sub}";
    public const string EndEnum = $"{End} {Enum}";
    public const string EndFunction = $"{End} {Function}";
    public const string EndProperty = $"{End} {Property}";
    public const string EndSelect = $"{End} {Select}";
    public const string EndType = $"{End} {Type}";
    public const string EndWith = $"{End} {With}";
    public const string EndIf = $"{End} {If}";
    public const string ForEach = $"{For} {Each}";
    public const string PropertyGet = $"{Property} {Get}";
    public const string PropertyLet = $"{Property} {Let}";
    public const string PropertySet = $"{Property} {Set}";

    public const string VB_Name = "VB_Name";
    public const string VB_GlobalNameSpace = "VB_GlobalNameSpace";
    public const string VB_Creatable = "VB_Creatable";
    public const string VB_PredeclaredId = "VB_PredeclaredId";
    public const string VB_Exposed = "VB_Exposed";
    public const string VB_Ext_Key = "VB_Ext_Key";
    public const string VB_Description = "VB_Description";
    public const string VB_UserMemId = "VB_UserMemId";
    public const string VB_MemberFlags = "VB_MemberFlags";
    public const string VB_Customizable = "VB_Customizable";
    public const string VB_Invoke_Func = "VB_ProcData.VB_Invoke_Func";

    public const string PowerOp = "^";
    public const string NegationOp = "-";
    public const string AdditionOp = "+";
    public const string SubtractionOp = "-";
    public const string MultiplicationOp = "*";
    public const string DivisionOp = "/";
    public const string IntegerDivisionOp = "\\";
    public const string ModuloOp = $"{Mod}";
    public const string ConcatOp = "&";
    public const string CompareEqualOp = "=";
    public const string CompareNotEqualOp = "<>";
    public const string CompareLikeOp = $"{Like}";
    public const string CompareIsOp = $"{Is}";
    public const string CompareGreaterThanOp = ">";
    public const string CompareGreaterThanOrEqualOp = ">=";
    public const string CompareLessThanOp = "<";
    public const string CompareLessThanOrEqualOp = "<=";
    public const string LogicalNotOp = $"{Not}";
    public const string LogicalAndOp = $"{And}";
    public const string LogicalOrOp = $"{Or}";
    public const string LogicalXOrOp = $"{XOr}";
    public const string LogicalEqvOp = $"{Eqv}";
    public const string LogicalImpOp = $"{Imp}";
}
