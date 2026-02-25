namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B6")]
public class PlayerProxy : InstanceProxy
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001000")]
	private readonly Player player; //Field offset: 0x18

	[Token(Token = "0x17000C19")]
	public bool Anchored
	{
		[Address(RVA = "0x4A7830", Offset = "0x4A6A30", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002861")]
		 get { } //Length: 30
		[Address(RVA = "0x4A7E00", Offset = "0x4A7000", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002862")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C18")]
	public bool CanMove
	{
		[Address(RVA = "0x4A7850", Offset = "0x4A6A50", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285F")]
		 get { } //Length: 30
		[Address(RVA = "0x4A7E20", Offset = "0x4A7020", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_CanMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002860")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C17")]
	public Color ChatColor
	{
		[Address(RVA = "0x4A7870", Offset = "0x4A6A70", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285D")]
		 get { } //Length: 36
		[Address(RVA = "0x4A7E40", Offset = "0x4A7040", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_ChatColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285E")]
		 set { } //Length: 44
	}

	[LuaEventParameter(typeof(string), "message", False)]
	[LuaEventParameter(typeof(PlayerChatEvent), "event", False)]
	[Token(Token = "0x17000C2A")]
	public LuaEvent Chatted
	{
		[Address(RVA = "0x4A78A0", Offset = "0x4A6AA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600287C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C2B")]
	public LuaEvent Died
	{
		[Address(RVA = "0x4A78C0", Offset = "0x4A6AC0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600287D")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C22")]
	public int FaceID
	{
		[Address(RVA = "0x4A78E0", Offset = "0x4A6AE0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002873")]
		 get { } //Length: 29
		[Address(RVA = "0x4A7E70", Offset = "0x4A7070", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002874")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C25")]
	public Vector3 Forward
	{
		[Address(RVA = "0x4A7900", Offset = "0x4A6B00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Forward", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002877")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000C1A")]
	public Color HeadColor
	{
		[Address(RVA = "0x4A7940", Offset = "0x4A6B40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_HeadColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002863")]
		 get { } //Length: 51
		[Address(RVA = "0x4A7E90", Offset = "0x4A7090", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_HeadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002864")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C0C")]
	public float Health
	{
		[Address(RVA = "0x4A3E00", Offset = "0x4A3000", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002847")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7EC0", Offset = "0x4A70C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Health", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002848")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C27")]
	public bool IsAdmin
	{
		[Address(RVA = "0x4A7980", Offset = "0x4A6B80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002879")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C28")]
	public bool IsCreator
	{
		[Address(RVA = "0x4A79A0", Offset = "0x4A6BA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600287A")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C23")]
	public bool IsInputFocused
	{
		[Address(RVA = "0x4A79C0", Offset = "0x4A6BC0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002875")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000C13")]
	public float JumpPower
	{
		[Address(RVA = "0x4A79E0", Offset = "0x4A6BE0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002855")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7EE0", Offset = "0x4A70E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_JumpPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002856")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C1C")]
	public Color LeftArmColor
	{
		[Address(RVA = "0x4A7A00", Offset = "0x4A6C00", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_LeftArmColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002867")]
		 get { } //Length: 51
		[Address(RVA = "0x4A7F00", Offset = "0x4A7100", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_LeftArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002868")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C1E")]
	public Color LeftLegColor
	{
		[Address(RVA = "0x4A7A40", Offset = "0x4A6C40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_LeftLegColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286B")]
		 get { } //Length: 51
		[Address(RVA = "0x4A7F30", Offset = "0x4A7130", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_LeftLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286C")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C0B")]
	public float MaxHealth
	{
		[Address(RVA = "0x4A7130", Offset = "0x4A6330", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002845")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7F60", Offset = "0x4A7160", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_MaxHealth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002846")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C11")]
	public float MaxStamina
	{
		[Address(RVA = "0x4A7A80", Offset = "0x4A6C80", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002851")]
		 get { } //Length: 31
		[Address(RVA = "0x4A7F80", Offset = "0x4A7180", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_MaxStamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002852")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C21")]
	public int PantsID
	{
		[Address(RVA = "0x4A7AA0", Offset = "0x4A6CA0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002871")]
		 get { } //Length: 29
		[Address(RVA = "0x4A7FA0", Offset = "0x4A71A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002872")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C14")]
	public Vector3 Position
	{
		[Address(RVA = "0x4A7AC0", Offset = "0x4A6CC0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002857")]
		 get { } //Length: 59
		[Address(RVA = "0x4A7FC0", Offset = "0x4A71C0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002858")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C2C")]
	public LuaEvent Respawned
	{
		[Address(RVA = "0x4A7B20", Offset = "0x4A6D20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600287E")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000C09")]
	public float RespawnTime
	{
		[Address(RVA = "0x4A7B00", Offset = "0x4A6D00", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002841")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8000", Offset = "0x4A7200", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_RespawnTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002842")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C26")]
	public Vector3 Right
	{
		[Address(RVA = "0x4A7BC0", Offset = "0x4A6DC0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Right", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002878")]
		 get { } //Length: 59
	}

	[Token(Token = "0x17000C1D")]
	public Color RightArmColor
	{
		[Address(RVA = "0x4A7B40", Offset = "0x4A6D40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_RightArmColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002869")]
		 get { } //Length: 51
		[Address(RVA = "0x4A8020", Offset = "0x4A7220", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_RightArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286A")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C1F")]
	public Color RightLegColor
	{
		[Address(RVA = "0x4A7B80", Offset = "0x4A6D80", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_RightLegColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286D")]
		 get { } //Length: 51
		[Address(RVA = "0x4A8050", Offset = "0x4A7250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_RightLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286E")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C15")]
	public Vector3 Rotation
	{
		[Address(RVA = "0x4A7C00", Offset = "0x4A6E00", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Rotation", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002859")]
		 get { } //Length: 59
		[Address(RVA = "0x4A8080", Offset = "0x4A7280", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285A")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C20")]
	public int ShirtID
	{
		[Address(RVA = "0x4A7C40", Offset = "0x4A6E40", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600286F")]
		 get { } //Length: 29
		[Address(RVA = "0x4A80C0", Offset = "0x4A72C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002870")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C24")]
	public Seat SittingIn
	{
		[Address(RVA = "0x4A7C60", Offset = "0x4A6E60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002876")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000C16")]
	public Vector3 Size
	{
		[Address(RVA = "0x4A7C80", Offset = "0x4A6E80", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Size", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285B")]
		 get { } //Length: 59
		[Address(RVA = "0x4A80E0", Offset = "0x4A72E0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600285C")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C0E")]
	public float SprintSpeed
	{
		[Address(RVA = "0x4A7CC0", Offset = "0x4A6EC0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284B")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8120", Offset = "0x4A7320", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_SprintSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C10")]
	public float Stamina
	{
		[Address(RVA = "0x4A7D20", Offset = "0x4A6F20", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284F")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8180", Offset = "0x4A7380", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Stamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002850")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C0F")]
	public bool StaminaEnabled
	{
		[Address(RVA = "0x4A7CE0", Offset = "0x4A6EE0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284D")]
		 get { } //Length: 30
		[Address(RVA = "0x4A8140", Offset = "0x4A7340", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_StaminaEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C12")]
	public float StaminaRegen
	{
		[Address(RVA = "0x4A7D00", Offset = "0x4A6F00", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002853")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8160", Offset = "0x4A7360", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_StaminaRegen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002854")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000C1B")]
	public Color TorsoColor
	{
		[Address(RVA = "0x4A7D40", Offset = "0x4A6F40", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_TorsoColor", ReturnType = typeof(Color))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002865")]
		 get { } //Length: 51
		[Address(RVA = "0x4A81A0", Offset = "0x4A73A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_TorsoColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002866")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000C29")]
	public int UserID
	{
		[Address(RVA = "0x4A7D80", Offset = "0x4A6F80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600287B")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000C0A")]
	public Vector3 Velocity
	{
		[Address(RVA = "0x4A7DA0", Offset = "0x4A6FA0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "get_Velocity", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002843")]
		 get { } //Length: 59
		[Address(RVA = "0x4A81D0", Offset = "0x4A73D0", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002844")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000C0D")]
	public float WalkSpeed
	{
		[Address(RVA = "0x4A7DE0", Offset = "0x4A6FE0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002849")]
		 get { } //Length: 31
		[Address(RVA = "0x4A8210", Offset = "0x4A7410", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Player), Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600284A")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A1050", Offset = "0x4A0250", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002840")]
	public PlayerProxy(Player target) { }

	[Address(RVA = "0x4A7360", Offset = "0x4A6560", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "ClearAppearance", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002885")]
	public void ClearAppearance() { }

	[Address(RVA = "0x4A7830", Offset = "0x4A6A30", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002861")]
	public bool get_Anchored() { }

	[Address(RVA = "0x4A7850", Offset = "0x4A6A50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285F")]
	public bool get_CanMove() { }

	[Address(RVA = "0x4A7870", Offset = "0x4A6A70", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285D")]
	public Color get_ChatColor() { }

	[Address(RVA = "0x4A78A0", Offset = "0x4A6AA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600287C")]
	public LuaEvent get_Chatted() { }

	[Address(RVA = "0x4A78C0", Offset = "0x4A6AC0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600287D")]
	public LuaEvent get_Died() { }

	[Address(RVA = "0x4A78E0", Offset = "0x4A6AE0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002873")]
	public int get_FaceID() { }

	[Address(RVA = "0x4A7900", Offset = "0x4A6B00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002877")]
	public Vector3 get_Forward() { }

	[Address(RVA = "0x4A7940", Offset = "0x4A6B40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_HeadColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002863")]
	public Color get_HeadColor() { }

	[Address(RVA = "0x4A3E00", Offset = "0x4A3000", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002847")]
	public float get_Health() { }

	[Address(RVA = "0x4A7980", Offset = "0x4A6B80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002879")]
	public bool get_IsAdmin() { }

	[Address(RVA = "0x4A79A0", Offset = "0x4A6BA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600287A")]
	public bool get_IsCreator() { }

	[Address(RVA = "0x4A79C0", Offset = "0x4A6BC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_IsInputFocused", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002875")]
	public bool get_IsInputFocused() { }

	[Address(RVA = "0x4A79E0", Offset = "0x4A6BE0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002855")]
	public float get_JumpPower() { }

	[Address(RVA = "0x4A7A00", Offset = "0x4A6C00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_LeftArmColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002867")]
	public Color get_LeftArmColor() { }

	[Address(RVA = "0x4A7A40", Offset = "0x4A6C40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_LeftLegColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286B")]
	public Color get_LeftLegColor() { }

	[Address(RVA = "0x4A7130", Offset = "0x4A6330", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002845")]
	public float get_MaxHealth() { }

	[Address(RVA = "0x4A7A80", Offset = "0x4A6C80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002851")]
	public float get_MaxStamina() { }

	[Address(RVA = "0x4A7AA0", Offset = "0x4A6CA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002871")]
	public int get_PantsID() { }

	[Address(RVA = "0x4A7AC0", Offset = "0x4A6CC0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002857")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x4A7B20", Offset = "0x4A6D20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600287E")]
	public LuaEvent get_Respawned() { }

	[Address(RVA = "0x4A7B00", Offset = "0x4A6D00", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002841")]
	public float get_RespawnTime() { }

	[Address(RVA = "0x4A7BC0", Offset = "0x4A6DC0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002878")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x4A7B40", Offset = "0x4A6D40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_RightArmColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002869")]
	public Color get_RightArmColor() { }

	[Address(RVA = "0x4A7B80", Offset = "0x4A6D80", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_RightLegColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286D")]
	public Color get_RightLegColor() { }

	[Address(RVA = "0x4A7C00", Offset = "0x4A6E00", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Rotation", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002859")]
	public Vector3 get_Rotation() { }

	[Address(RVA = "0x4A7C40", Offset = "0x4A6E40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286F")]
	public int get_ShirtID() { }

	[Address(RVA = "0x4A7C60", Offset = "0x4A6E60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002876")]
	public Seat get_SittingIn() { }

	[Address(RVA = "0x4A7C80", Offset = "0x4A6E80", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285B")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x4A7CC0", Offset = "0x4A6EC0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284B")]
	public float get_SprintSpeed() { }

	[Address(RVA = "0x4A7D20", Offset = "0x4A6F20", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284F")]
	public float get_Stamina() { }

	[Address(RVA = "0x4A7CE0", Offset = "0x4A6EE0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284D")]
	public bool get_StaminaEnabled() { }

	[Address(RVA = "0x4A7D00", Offset = "0x4A6F00", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002853")]
	public float get_StaminaRegen() { }

	[Address(RVA = "0x4A7D40", Offset = "0x4A6F40", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_TorsoColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002865")]
	public Color get_TorsoColor() { }

	[Address(RVA = "0x4A7D80", Offset = "0x4A6F80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600287B")]
	public int get_UserID() { }

	[Address(RVA = "0x4A7DA0", Offset = "0x4A6FA0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "get_Velocity", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002843")]
	public Vector3 get_Velocity() { }

	[Address(RVA = "0x4A7DE0", Offset = "0x4A6FE0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002849")]
	public float get_WalkSpeed() { }

	[Address(RVA = "0x4A7380", Offset = "0x4A6580", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "InverseTransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288F")]
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	[Address(RVA = "0x4A73E0", Offset = "0x4A65E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288D")]
	public Vector3 InverseTransformPoint(Vector3 point) { }

	[Address(RVA = "0x4A7440", Offset = "0x4A6640", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "InverseTransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002891")]
	public Vector3 InverseTransformVector(Vector3 vector) { }

	[Address(RVA = "0x4A74A0", Offset = "0x4A66A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Kick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002880")]
	public void Kick(string reason = "You have been kicked from the server.") { }

	[Address(RVA = "0x4A74C0", Offset = "0x4A66C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "LoadAppearance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002884")]
	public void LoadAppearance(int userID) { }

	[Address(RVA = "0x4A7550", Offset = "0x4A6750", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002888")]
	public void LookAt(Vector3 lookTarget) { }

	[Address(RVA = "0x4A74E0", Offset = "0x4A66E0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002887")]
	public void LookAt(Vector3 lookTarget, Vector3 worldUp) { }

	[Address(RVA = "0x4A7530", Offset = "0x4A6730", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "LookAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DynamicInstance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002889")]
	public void LookAt(DynamicInstance instance) { }

	[Address(RVA = "0x4A7590", Offset = "0x4A6790", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "OwnsItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(DynValue)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[LuaCallbackParameter("callback", typeof(bool), "success", False)]
	[LuaCallbackParameter("callback", typeof(bool), "owned", False)]
	[Token(Token = "0x600287F")]
	public void OwnsItem(int assetId, DynValue callback) { }

	[Address(RVA = "0x4A75B0", Offset = "0x4A67B0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "ResetAppearance", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002886")]
	public void ResetAppearance() { }

	[Address(RVA = "0x4A75D0", Offset = "0x4A67D0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Respawn", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002883")]
	public void Respawn() { }

	[Address(RVA = "0x4A7650", Offset = "0x4A6850", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Rotate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288C")]
	public void Rotate(Vector3 eulerAngles) { }

	[Address(RVA = "0x4A75F0", Offset = "0x4A67F0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "RotateAround", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288B")]
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	[Address(RVA = "0x4A7E00", Offset = "0x4A7000", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Anchored", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002862")]
	public void set_Anchored(bool value) { }

	[Address(RVA = "0x4A7E20", Offset = "0x4A7020", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_CanMove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002860")]
	public void set_CanMove(bool value) { }

	[Address(RVA = "0x4A7E40", Offset = "0x4A7040", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_ChatColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285E")]
	public void set_ChatColor(Color value) { }

	[Address(RVA = "0x4A7E70", Offset = "0x4A7070", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_FaceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002874")]
	public void set_FaceID(int value) { }

	[Address(RVA = "0x4A7E90", Offset = "0x4A7090", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_HeadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002864")]
	public void set_HeadColor(Color value) { }

	[Address(RVA = "0x4A7EC0", Offset = "0x4A70C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Health", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002848")]
	public void set_Health(float value) { }

	[Address(RVA = "0x4A7EE0", Offset = "0x4A70E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_JumpPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002856")]
	public void set_JumpPower(float value) { }

	[Address(RVA = "0x4A7F00", Offset = "0x4A7100", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_LeftArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002868")]
	public void set_LeftArmColor(Color value) { }

	[Address(RVA = "0x4A7F30", Offset = "0x4A7130", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_LeftLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286C")]
	public void set_LeftLegColor(Color value) { }

	[Address(RVA = "0x4A7F60", Offset = "0x4A7160", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_MaxHealth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002846")]
	public void set_MaxHealth(float value) { }

	[Address(RVA = "0x4A7F80", Offset = "0x4A7180", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_MaxStamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002852")]
	public void set_MaxStamina(float value) { }

	[Address(RVA = "0x4A7FA0", Offset = "0x4A71A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_PantsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002872")]
	public void set_PantsID(int value) { }

	[Address(RVA = "0x4A7FC0", Offset = "0x4A71C0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002858")]
	public void set_Position(Vector3 value) { }

	[Address(RVA = "0x4A8000", Offset = "0x4A7200", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_RespawnTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002842")]
	public void set_RespawnTime(float value) { }

	[Address(RVA = "0x4A8020", Offset = "0x4A7220", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_RightArmColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286A")]
	public void set_RightArmColor(Color value) { }

	[Address(RVA = "0x4A8050", Offset = "0x4A7250", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_RightLegColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600286E")]
	public void set_RightLegColor(Color value) { }

	[Address(RVA = "0x4A8080", Offset = "0x4A7280", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285A")]
	public void set_Rotation(Vector3 value) { }

	[Address(RVA = "0x4A80C0", Offset = "0x4A72C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_ShirtID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002870")]
	public void set_ShirtID(int value) { }

	[Address(RVA = "0x4A80E0", Offset = "0x4A72E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600285C")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x4A8120", Offset = "0x4A7320", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_SprintSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284C")]
	public void set_SprintSpeed(float value) { }

	[Address(RVA = "0x4A8180", Offset = "0x4A7380", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Stamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002850")]
	public void set_Stamina(float value) { }

	[Address(RVA = "0x4A8140", Offset = "0x4A7340", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_StaminaEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284E")]
	public void set_StaminaEnabled(bool value) { }

	[Address(RVA = "0x4A8160", Offset = "0x4A7360", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_StaminaRegen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002854")]
	public void set_StaminaRegen(float value) { }

	[Address(RVA = "0x4A81A0", Offset = "0x4A73A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_TorsoColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002866")]
	public void set_TorsoColor(Color value) { }

	[Address(RVA = "0x4A81D0", Offset = "0x4A73D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_Velocity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002844")]
	public void set_Velocity(Vector3 value) { }

	[Address(RVA = "0x4A8210", Offset = "0x4A7410", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600284A")]
	public void set_WalkSpeed(float value) { }

	[Address(RVA = "0x4A7690", Offset = "0x4A6890", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Sit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Seat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002881")]
	public void Sit(Seat seat) { }

	[Address(RVA = "0x4A76B0", Offset = "0x4A68B0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "TransformDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002890")]
	public Vector3 TransformDirection(Vector3 direction) { }

	[Address(RVA = "0x4A7710", Offset = "0x4A6910", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288E")]
	public Vector3 TransformPoint(Vector3 point) { }

	[Address(RVA = "0x4A7770", Offset = "0x4A6970", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "TransformVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002892")]
	public Vector3 TransformVector(Vector3 vector) { }

	[Address(RVA = "0x4A77D0", Offset = "0x4A69D0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Translate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600288A")]
	public void Translate(Vector3 translation) { }

	[Address(RVA = "0x4A7810", Offset = "0x4A6A10", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Player), Member = "Unsit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002882")]
	public void Unsit(bool addForce = true) { }

}

