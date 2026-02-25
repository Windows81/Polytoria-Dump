namespace System;

[Token(Token = "0x2000166")]
public sealed class OperatingSystem : ISerializable, ICloneable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400056C")]
	private readonly Version _version; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400056D")]
	private readonly PlatformID _platform; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400056E")]
	private readonly string _servicePack; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400056F")]
	private string _versionString; //Field offset: 0x28

	[Token(Token = "0x17000108")]
	public PlatformID Platform
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C3D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000109")]
	public string VersionString
	{
		[Address(RVA = "0x14BB320", Offset = "0x14BA520", Length = "0xB4")]
		[CalledBy(Type = typeof(OperatingSystem), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000C40")]
		 get { } //Length: 180
	}

	[Address(RVA = "0x14BB190", Offset = "0x14BA390", Length = "0x1A")]
	[CalledBy(Type = typeof(Environment), Member = "get_OSVersion", ReturnType = typeof(OperatingSystem))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C3A")]
	public OperatingSystem(PlatformID platform, Version version) { }

	[Address(RVA = "0x14BB1B0", Offset = "0x14BA3B0", Length = "0x165")]
	[CalledBy(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OperatingSystem), Member = "Clone", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C3B")]
	internal OperatingSystem(PlatformID platform, Version version, string servicePack) { }

	[Address(RVA = "0x14BB0C0", Offset = "0x14BA2C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OperatingSystem), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlatformID), typeof(Version), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000C3E")]
	public override object Clone() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C3D")]
	public PlatformID get_Platform() { }

	[Address(RVA = "0x14BB320", Offset = "0x14BA520", Length = "0xB4")]
	[CalledBy(Type = typeof(OperatingSystem), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000C40")]
	public string get_VersionString() { }

	[Address(RVA = "0x14BB140", Offset = "0x14BA340", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000C3C")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x14BB180", Offset = "0x14BA380", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OperatingSystem), Member = "get_VersionString", ReturnType = typeof(string))]
	[Token(Token = "0x6000C3F")]
	public virtual string ToString() { }

}

