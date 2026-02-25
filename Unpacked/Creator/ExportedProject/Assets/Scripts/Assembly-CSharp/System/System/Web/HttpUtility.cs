namespace System.Web;

[Token(Token = "0x20000D7")]
public sealed class HttpUtility
{

	[Address(RVA = "0x1756060", Offset = "0x1755260", Length = "0x235")]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "HandleXmlNodes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"U8Xml.XmlNodeList", "Polytoria.Datamodel.Instance"}, ReturnType = "Polytoria.Datamodel.Instance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringWriter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000461")]
	public static string HtmlDecode(string s) { }

}

