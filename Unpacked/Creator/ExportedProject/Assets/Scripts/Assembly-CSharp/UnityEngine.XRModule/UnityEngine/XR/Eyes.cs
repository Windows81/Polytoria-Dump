namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("XRScriptingClasses.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000C")]
public struct Eyes : IEquatable<Eyes>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003C")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003D")]
	private uint m_FeatureIndex; //Field offset: 0x8

	[Token(Token = "0x17000009")]
	internal ulong deviceId
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x1700000A")]
	internal uint featureIndex
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000015")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1D012C0", Offset = "0x1D004C0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000016")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1D011A0", Offset = "0x1D003A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000017")]
	public override bool Equals(Eyes other) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	internal ulong get_deviceId() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	internal uint get_featureIndex() { }

	[Address(RVA = "0x1D01270", Offset = "0x1D00470", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public virtual int GetHashCode() { }

}

