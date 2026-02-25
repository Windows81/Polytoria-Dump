//Type is in global namespace

[Token(Token = "0x2000002")]
internal static class SR
{

	[Address(RVA = "0x163CB00", Offset = "0x163BD00", Length = "0x63")]
	[CalledBy(Type = typeof(XAttribute), Member = "ValidateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XName), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XDocument), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "ValidateNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode), typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XName), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XName))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000001")]
	internal static string Format(string resourceFormat, object p1) { }

}

