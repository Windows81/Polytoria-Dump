namespace UnityEngine;

[Token(Token = "0x2000005")]
[UsedByNativeCode("SubsystemDescriptorBase")]
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000003")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.XRModule"})]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public override string id
	{
		[Address(RVA = "0x1A19AA0", Offset = "0x1A18CA0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SubsystemDescriptorBindings), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
		[Token(Token = "0x6000006")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	protected IntegratedSubsystemDescriptor() { }

	[Address(RVA = "0x1A19AA0", Offset = "0x1A18CA0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SubsystemDescriptorBindings), Member = "GetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000006")]
	public override string get_id() { }

}

