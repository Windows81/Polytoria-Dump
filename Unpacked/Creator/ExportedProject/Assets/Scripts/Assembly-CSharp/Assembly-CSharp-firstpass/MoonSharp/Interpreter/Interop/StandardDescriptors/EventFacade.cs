namespace MoonSharp.Interpreter.Interop.StandardDescriptors;

[Token(Token = "0x2000119")]
internal class EventFacade : IUserDataType
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046E")]
	private Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> m_AddCallback; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400046F")]
	private Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> m_RemoveCallback; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000470")]
	private object m_Object; //Field offset: 0x20

	[Address(RVA = "0x331CE0", Offset = "0x330EE0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A95")]
	public EventFacade(EventMemberDescriptor parent, object obj) { }

	[Address(RVA = "0x331C70", Offset = "0x330E70", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A96")]
	public EventFacade(Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> addCallback, Func<Object, ScriptExecutionContext, CallbackArguments, DynValue> removeCallback, object obj) { }

	[Address(RVA = "0x331BF0", Offset = "0x330DF0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000A9A")]
	private DynValue <Index>b__5_0(ScriptExecutionContext c, CallbackArguments a) { }

	[Address(RVA = "0x331C30", Offset = "0x330E30", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000A9B")]
	private DynValue <Index>b__5_1(ScriptExecutionContext c, CallbackArguments a) { }

	[Address(RVA = "0x331A30", Offset = "0x330C30", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DynValue), Member = "get_String", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DynValue), Member = "NewCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<MoonSharp.Interpreter.ScriptExecutionContext, MoonSharp.Interpreter.CallbackArguments, MoonSharp.Interpreter.DynValue>), typeof(string)}, ReturnType = typeof(DynValue))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000A97")]
	public override DynValue Index(Script script, DynValue index, bool isDirectIndexing) { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A99")]
	public override DynValue MetaIndex(Script script, string metaname) { }

	[Address(RVA = "0x331BA0", Offset = "0x330DA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A98")]
	public override bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing) { }

}

