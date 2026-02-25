namespace System.Text.RegularExpressions;

[Token(Token = "0x20000DF")]
public class Group : Capture
{
	[Token(Token = "0x4000355")]
	internal static readonly Group s_emptyGroup; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000356")]
	internal readonly Int32[] _caps; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000357")]
	internal int _capcount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000358")]
	internal CaptureCollection _capcoll; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000359")]
	private readonly string <Name>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000CF")]
	public bool Success
	{
		[Address(RVA = "0x17511F0", Offset = "0x17503F0", Length = "0x8")]
		[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "MatchCustomIdent", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(string))]
		[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "ReParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 6)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600049F")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1750FA0", Offset = "0x17501A0", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004A0")]
	private static Group() { }

	[Address(RVA = "0x1751120", Offset = "0x1750320", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600049E")]
	internal Group(string text, Int32[] caps, int capcount, string name) { }

	[Address(RVA = "0x17510F0", Offset = "0x17502F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA60")]
	[Token(Token = "0x60004A1")]
	internal Group() { }

	[Address(RVA = "0x17511F0", Offset = "0x17503F0", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StylePropertyValueMatcher", Member = "MatchCustomIdent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexReplacement), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Regex), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.LuaStateInterop.Tools", Member = "sprintf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Object[]"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "ReParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600049F")]
	public bool get_Success() { }

}

