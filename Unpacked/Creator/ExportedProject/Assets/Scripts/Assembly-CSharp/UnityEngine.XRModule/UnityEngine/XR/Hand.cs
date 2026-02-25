namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[NativeHeader("XRScriptingClasses.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[RequiredByNativeCode]
[StaticAccessor("XRInputDevices::Get()", StaticAccessorType::Dot (0))]
[Token(Token = "0x200000B")]
public struct Hand : IEquatable<Hand>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003A")]
	private ulong m_DeviceId; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400003B")]
	private uint m_FeatureIndex; //Field offset: 0x8

	[Token(Token = "0x17000007")]
	internal ulong deviceId
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	internal uint featureIndex
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000010")]
		internal get { } //Length: 6
	}

	[Address(RVA = "0x1D01370", Offset = "0x1D00570", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000011")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1D011A0", Offset = "0x1D003A0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public override bool Equals(Hand other) { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	internal ulong get_deviceId() { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000010")]
	internal uint get_featureIndex() { }

	[Address(RVA = "0x1D01270", Offset = "0x1D00470", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public virtual int GetHashCode() { }

}

