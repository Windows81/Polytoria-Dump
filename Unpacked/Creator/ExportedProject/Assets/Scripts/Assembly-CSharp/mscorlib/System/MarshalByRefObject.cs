namespace System;

[ComVisible(True)]
[Token(Token = "0x20001B5")]
public abstract class MarshalByRefObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071B")]
	private object _identity; //Field offset: 0x10

	[Token(Token = "0x17000166")]
	internal ServerIdentity ObjectIdentity
	{
		[Address(RVA = "0x14F7220", Offset = "0x14F6420", Length = "0x3E")]
		[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000F6E")]
		internal get { } //Length: 62
		[Address(RVA = "0x14F7260", Offset = "0x14F6460", Length = "0x3E")]
		[CalledBy(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000F6F")]
		internal set { } //Length: 62
	}

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F6D")]
	protected MarshalByRefObject() { }

	[Address(RVA = "0x14F71A0", Offset = "0x14F63A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F70")]
	public override ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x14F7220", Offset = "0x14F6420", Length = "0x3E")]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F6E")]
	internal ServerIdentity get_ObjectIdentity() { }

	[Address(RVA = "0x14F71E0", Offset = "0x14F63E0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F71")]
	public override object InitializeLifetimeService() { }

	[Address(RVA = "0x14F7260", Offset = "0x14F6460", Length = "0x3E")]
	[CalledBy(Type = typeof(ServerIdentity), Member = "DisposeServerObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SingleCallIdentity), Member = "SyncObjectProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage)}, ReturnType = typeof(IMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000F6F")]
	internal void set_ObjectIdentity(ServerIdentity value) { }

}

