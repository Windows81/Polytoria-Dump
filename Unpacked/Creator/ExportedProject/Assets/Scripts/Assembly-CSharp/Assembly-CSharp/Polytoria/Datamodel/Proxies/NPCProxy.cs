namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B0")]
public class NPCProxy : DynamicInstanceProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFA")]
	private readonly NPC npc; //Field offset: 0x20

	[Token(Token = "0x17000BC6")]
	public bool Anchored
	{
		[Address(RVA = "0x4A5CF0", Offset = "0x4A4EF0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027AB")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6050", Offset = "0x4A5250", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027AC")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BBE")]
	public LuaEvent Died
	{
		[Address(RVA = "0x4A5D10", Offset = "0x4A4F10", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600279C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BCB")]
	public int FaceID
	{
		[Address(RVA = "0x4A5D30", Offset = "0x4A4F30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B5")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6070", Offset = "0x4A5270", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B6")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BD2")]
	public bool Grounded
	{
		[Address(RVA = "0x4A5D50", Offset = "0x4A4F50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027C0")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BC0")]
	public Color HeadColor
	{
		[Address(RVA = "0x4A5D70", Offset = "0x4A4F70", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_HeadColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600279F")]
		 get { } //Length: 51
		[Address(RVA = "0x4A6090", Offset = "0x4A5290", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_HeadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A0")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BC7")]
	public float Health
	{
		[Address(RVA = "0x4A5DB0", Offset = "0x4A4FB0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027AD")]
		 get { } //Length: 31
		[Address(RVA = "0x4A60C0", Offset = "0x4A52C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60027AE")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BCD")]
	public float JumpPower
	{
		[Address(RVA = "0x4A5DD0", Offset = "0x4A4FD0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B9")]
		 get { } //Length: 31
		[Address(RVA = "0x4A60E0", Offset = "0x4A52E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60027BA")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BC2")]
	public Color LeftArmColor
	{
		[Address(RVA = "0x4A5DF0", Offset = "0x4A4FF0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_LeftArmColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A3")]
		 get { } //Length: 51
		[Address(RVA = "0x4A6100", Offset = "0x4A5300", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_LeftArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A4")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BC4")]
	public Color LeftLegColor
	{
		[Address(RVA = "0x4A5E30", Offset = "0x4A5030", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_LeftLegColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A7")]
		 get { } //Length: 51
		[Address(RVA = "0x4A6130", Offset = "0x4A5330", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_LeftLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A8")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BC8")]
	public float MaxHealth
	{
		[Address(RVA = "0x4A5E70", Offset = "0x4A5070", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027AF")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6160", Offset = "0x4A5360", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60027B0")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BBF")]
	public Instance MoveTarget
	{
		[Address(RVA = "0x4A5E90", Offset = "0x4A5090", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600279D")]
		 get { } //Length: 30
		[Address(RVA = "0x4A6180", Offset = "0x4A5380", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_MoveTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600279E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BCF")]
	public float NavDestinationDistance
	{
		[Address(RVA = "0x4A5EB0", Offset = "0x4A50B0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_NavDestinationDistance", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BD")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BD0")]
	public bool NavDestinationReached
	{
		[Address(RVA = "0x4A5ED0", Offset = "0x4A50D0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_NavDestinationReached", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BE")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BD1")]
	public bool NavDestinationValid
	{
		[Address(RVA = "0x4A5EF0", Offset = "0x4A50F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BF")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BCA")]
	public int PantsID
	{
		[Address(RVA = "0x4A5F10", Offset = "0x4A5110", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027B3")]
		 get { } //Length: 29
		[Address(RVA = "0x4A61A0", Offset = "0x4A53A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B4")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BC3")]
	public Color RightArmColor
	{
		[Address(RVA = "0x4A5F30", Offset = "0x4A5130", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_RightArmColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A5")]
		 get { } //Length: 51
		[Address(RVA = "0x4A61C0", Offset = "0x4A53C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_RightArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A6")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BC5")]
	public Color RightLegColor
	{
		[Address(RVA = "0x4A5F70", Offset = "0x4A5170", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_RightLegColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A9")]
		 get { } //Length: 51
		[Address(RVA = "0x4A61F0", Offset = "0x4A53F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_RightLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027AA")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BC9")]
	public int ShirtID
	{
		[Address(RVA = "0x4A13F0", Offset = "0x4A05F0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027B1")]
		 get { } //Length: 29
		[Address(RVA = "0x4A6220", Offset = "0x4A5420", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B2")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BC1")]
	public Color TorsoColor
	{
		[Address(RVA = "0x4A5FB0", Offset = "0x4A51B0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_TorsoColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A1")]
		 get { } //Length: 51
		[Address(RVA = "0x4A6240", Offset = "0x4A5440", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_TorsoColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027A2")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000BCE")]
	public Vector3 Velocity
	{
		[Address(RVA = "0x4A5FF0", Offset = "0x4A51F0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "get_Velocity", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BB")]
		 get { } //Length: 59
		[Address(RVA = "0x4A6270", Offset = "0x4A5470", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BC")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000BCC")]
	public float WalkSpeed
	{
		[Address(RVA = "0x4A6030", Offset = "0x4A5230", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B7")]
		 get { } //Length: 31
		[Address(RVA = "0x4A62B0", Offset = "0x4A54B0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NPC), Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027B8")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x600279B")]
	public NPCProxy(NPC target) { }

	[Address(RVA = "0x4A5BF0", Offset = "0x4A4DF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "ClearAppearance", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C4")]
	public void ClearAppearance() { }

	[Address(RVA = "0x4A5C10", Offset = "0x4A4E10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "DropTool", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C7")]
	public void DropTool() { }

	[Address(RVA = "0x4A5C30", Offset = "0x4A4E30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "EquipTool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C6")]
	public void EquipTool(Tool tool) { }

	[Address(RVA = "0x4A5CF0", Offset = "0x4A4EF0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AB")]
	public bool get_Anchored() { }

	[Address(RVA = "0x4A5D10", Offset = "0x4A4F10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279C")]
	public LuaEvent get_Died() { }

	[Address(RVA = "0x4A5D30", Offset = "0x4A4F30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B5")]
	public int get_FaceID() { }

	[Address(RVA = "0x4A5D50", Offset = "0x4A4F50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C0")]
	public bool get_Grounded() { }

	[Address(RVA = "0x4A5D70", Offset = "0x4A4F70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_HeadColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279F")]
	public Color get_HeadColor() { }

	[Address(RVA = "0x4A5DB0", Offset = "0x4A4FB0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AD")]
	public float get_Health() { }

	[Address(RVA = "0x4A5DD0", Offset = "0x4A4FD0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B9")]
	public float get_JumpPower() { }

	[Address(RVA = "0x4A5DF0", Offset = "0x4A4FF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_LeftArmColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A3")]
	public Color get_LeftArmColor() { }

	[Address(RVA = "0x4A5E30", Offset = "0x4A5030", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_LeftLegColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A7")]
	public Color get_LeftLegColor() { }

	[Address(RVA = "0x4A5E70", Offset = "0x4A5070", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AF")]
	public float get_MaxHealth() { }

	[Address(RVA = "0x4A5E90", Offset = "0x4A5090", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279D")]
	public Instance get_MoveTarget() { }

	[Address(RVA = "0x4A5EB0", Offset = "0x4A50B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_NavDestinationDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BD")]
	public float get_NavDestinationDistance() { }

	[Address(RVA = "0x4A5ED0", Offset = "0x4A50D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_NavDestinationReached", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BE")]
	public bool get_NavDestinationReached() { }

	[Address(RVA = "0x4A5EF0", Offset = "0x4A50F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_NavDestinationValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BF")]
	public bool get_NavDestinationValid() { }

	[Address(RVA = "0x4A5F10", Offset = "0x4A5110", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027B3")]
	public int get_PantsID() { }

	[Address(RVA = "0x4A5F30", Offset = "0x4A5130", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_RightArmColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A5")]
	public Color get_RightArmColor() { }

	[Address(RVA = "0x4A5F70", Offset = "0x4A5170", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_RightLegColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A9")]
	public Color get_RightLegColor() { }

	[Address(RVA = "0x4A13F0", Offset = "0x4A05F0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027B1")]
	public int get_ShirtID() { }

	[Address(RVA = "0x4A5FB0", Offset = "0x4A51B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_TorsoColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A1")]
	public Color get_TorsoColor() { }

	[Address(RVA = "0x4A5FF0", Offset = "0x4A51F0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "get_Velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BB")]
	public Vector3 get_Velocity() { }

	[Address(RVA = "0x4A6030", Offset = "0x4A5230", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B7")]
	public float get_WalkSpeed() { }

	[Address(RVA = "0x4A5C50", Offset = "0x4A4E50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "Jump", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C2")]
	public void Jump() { }

	[Address(RVA = "0x4A5C70", Offset = "0x4A4E70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "LoadAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C3")]
	public void LoadAppearance(int userID) { }

	[Address(RVA = "0x4A5C90", Offset = "0x4A4E90", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "Respawn", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C1")]
	public void Respawn() { }

	[Address(RVA = "0x4A6050", Offset = "0x4A5250", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AC")]
	public void set_Anchored(bool value) { }

	[Address(RVA = "0x4A6070", Offset = "0x4A5270", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B6")]
	public void set_FaceID(int value) { }

	[Address(RVA = "0x4A6090", Offset = "0x4A5290", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_HeadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A0")]
	public void set_HeadColor(Color value) { }

	[Address(RVA = "0x4A60C0", Offset = "0x4A52C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027AE")]
	public void set_Health(float value) { }

	[Address(RVA = "0x4A60E0", Offset = "0x4A52E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027BA")]
	public void set_JumpPower(float value) { }

	[Address(RVA = "0x4A6100", Offset = "0x4A5300", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_LeftArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A4")]
	public void set_LeftArmColor(Color value) { }

	[Address(RVA = "0x4A6130", Offset = "0x4A5330", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_LeftLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A8")]
	public void set_LeftLegColor(Color value) { }

	[Address(RVA = "0x4A6160", Offset = "0x4A5360", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027B0")]
	public void set_MaxHealth(float value) { }

	[Address(RVA = "0x4A6180", Offset = "0x4A5380", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_MoveTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600279E")]
	public void set_MoveTarget(Instance value) { }

	[Address(RVA = "0x4A61A0", Offset = "0x4A53A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B4")]
	public void set_PantsID(int value) { }

	[Address(RVA = "0x4A61C0", Offset = "0x4A53C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_RightArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A6")]
	public void set_RightArmColor(Color value) { }

	[Address(RVA = "0x4A61F0", Offset = "0x4A53F0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_RightLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027AA")]
	public void set_RightLegColor(Color value) { }

	[Address(RVA = "0x4A6220", Offset = "0x4A5420", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B2")]
	public void set_ShirtID(int value) { }

	[Address(RVA = "0x4A6240", Offset = "0x4A5440", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_TorsoColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027A2")]
	public void set_TorsoColor(Color value) { }

	[Address(RVA = "0x4A6270", Offset = "0x4A5470", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BC")]
	public void set_Velocity(Vector3 value) { }

	[Address(RVA = "0x4A62B0", Offset = "0x4A54B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027B8")]
	public void set_WalkSpeed(float value) { }

	[Address(RVA = "0x4A5CB0", Offset = "0x4A4EB0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NPC), Member = "SetNavDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C5")]
	public void SetNavDestination(Vector3 destination) { }

}

