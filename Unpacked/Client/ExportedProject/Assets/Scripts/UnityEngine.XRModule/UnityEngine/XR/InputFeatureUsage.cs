namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000009")]
public struct InputFeatureUsage : IEquatable<InputFeatureUsage>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000036")]
	internal string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[NativeName("m_FeatureType")]
	[Token(Token = "0x4000037")]
	internal InputFeatureType m_InternalType; //Field offset: 0x8

	[Token(Token = "0x17000005")]
	internal InputFeatureType internalType
	{
		[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000006")]
		internal get { } //Length: 6
	}

	[Token(Token = "0x17000004")]
	public string name
	{
		[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
		[CallerCount(Count = 95)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D01780", Offset = "0x1D00980", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000007")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1D01840", Offset = "0x1D00A40", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000008")]
	public override bool Equals(InputFeatureUsage other) { }

	[Address(RVA = "0xE118C0", Offset = "0xE10AC0", Length = "0x6")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	internal InputFeatureType get_internalType() { }

	[Address(RVA = "0x7065B0", Offset = "0x7057B0", Length = "0x6")]
	[CallerCount(Count = 95)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public string get_name() { }

	[Address(RVA = "0x1D01890", Offset = "0x1D00A90", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public virtual int GetHashCode() { }

}

