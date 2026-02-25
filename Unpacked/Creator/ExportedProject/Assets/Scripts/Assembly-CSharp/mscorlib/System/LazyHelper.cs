namespace System;

[Token(Token = "0x2000108")]
internal class LazyHelper
{
	[Token(Token = "0x4000425")]
	internal static readonly LazyHelper NoneViaConstructor; //Field offset: 0x0
	[Token(Token = "0x4000426")]
	internal static readonly LazyHelper NoneViaFactory; //Field offset: 0x8
	[Token(Token = "0x4000427")]
	internal static readonly LazyHelper PublicationOnlyViaConstructor; //Field offset: 0x10
	[Token(Token = "0x4000428")]
	internal static readonly LazyHelper PublicationOnlyViaFactory; //Field offset: 0x18
	[Token(Token = "0x4000429")]
	internal static readonly LazyHelper PublicationOnlyWaitForOtherThreadToPublish; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400042A")]
	private readonly LazyState <State>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400042B")]
	private readonly ExceptionDispatchInfo _exceptionDispatch; //Field offset: 0x18

	[Token(Token = "0x1700008C")]
	internal LazyState State
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600081B")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x14A1DD0", Offset = "0x14A0FD0", Length = "0x19E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000821")]
	private static LazyHelper() { }

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600081C")]
	internal LazyHelper(LazyState state) { }

	[Address(RVA = "0x14A1F70", Offset = "0x14A1170", Length = "0x6E")]
	[CalledBy(Type = typeof(Lazy`1), Member = "ViaFactory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LazyThreadSafetyMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081D")]
	internal LazyHelper(LazyThreadSafetyMode mode, Exception exception) { }

	[Address(RVA = "0x14A1C10", Offset = "0x14A0E10", Length = "0x19C")]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lazy`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<T>", typeof(LazyThreadSafetyMode), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600081F")]
	internal static LazyHelper Create(LazyThreadSafetyMode mode, bool useDefaultConstructor) { }

	[Address(RVA = "0x14A1BA0", Offset = "0x14A0DA0", Length = "0x64")]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateViaDefaultConstructor", ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MissingMemberException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000820")]
	internal static object CreateViaDefaultConstructor(Type type) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600081B")]
	internal LazyState get_State() { }

	[Address(RVA = "0x14A1DB0", Offset = "0x14A0FB0", Length = "0x1D")]
	[CalledBy(Type = typeof(Lazy`1), Member = "CreateValue", ReturnType = "T")]
	[CalledBy(Type = typeof(Lazy`1), Member = "get_Value", ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600081E")]
	internal void ThrowException() { }

}

