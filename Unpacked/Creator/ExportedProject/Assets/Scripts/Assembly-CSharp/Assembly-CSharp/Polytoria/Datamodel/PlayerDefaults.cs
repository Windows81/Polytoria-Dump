namespace Polytoria.Datamodel;

[Token(Token = "0x200034F")]
public class PlayerDefaults : Instance
{
	[FieldOffset(Offset = "0xF8")]
	[SyncVar]
	[Token(Token = "0x4000E03")]
	private float maxHealth; //Field offset: 0xF8
	[FieldOffset(Offset = "0xFC")]
	[SyncVar]
	[Token(Token = "0x4000E04")]
	private float walkSpeed; //Field offset: 0xFC
	[FieldOffset(Offset = "0x100")]
	[SyncVar]
	[Token(Token = "0x4000E05")]
	private float sprintSpeed; //Field offset: 0x100
	[FieldOffset(Offset = "0x104")]
	[SyncVar]
	[Token(Token = "0x4000E06")]
	private bool staminaEnabled; //Field offset: 0x104
	[FieldOffset(Offset = "0x108")]
	[SyncVar]
	[Token(Token = "0x4000E07")]
	private float stamina; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[SyncVar]
	[Token(Token = "0x4000E08")]
	private float maxStamina; //Field offset: 0x10C
	[FieldOffset(Offset = "0x110")]
	[SyncVar]
	[Token(Token = "0x4000E09")]
	private float staminaRegen; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SyncVar]
	[Token(Token = "0x4000E0A")]
	private float jumpPower; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[SyncVar]
	[Token(Token = "0x4000E0B")]
	private float respawnTime; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[SyncVar]
	[Token(Token = "0x4000E0C")]
	private Color chatColor; //Field offset: 0x11C

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A58")]
	public Color ChatColor
	{
		[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021ED")]
		 get { } //Length: 14
		[Address(RVA = "0x465060", Offset = "0x464260", Length = "0xCA")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021EE")]
		 set { } //Length: 202
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A56")]
	public float JumpPower
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E9")]
		 get { } //Length: 9
		[Address(RVA = "0x465130", Offset = "0x464330", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021EA")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A4F")]
	public float MaxHealth
	{
		[Address(RVA = "0x465030", Offset = "0x464230", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DB")]
		 get { } //Length: 9
		[Address(RVA = "0x4651F0", Offset = "0x4643F0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DC")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A54")]
	public float MaxStamina
	{
		[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E5")]
		 get { } //Length: 9
		[Address(RVA = "0x4652B0", Offset = "0x4644B0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E6")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A62")]
	public Color NetworkchatColor
	{
		[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002207")]
		 get { } //Length: 14
		[Address(RVA = "0x465060", Offset = "0x464260", Length = "0xCA")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002208")]
		 set { } //Length: 202
	}

	[Token(Token = "0x17000A60")]
	public float NetworkjumpPower
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002203")]
		 get { } //Length: 9
		[Address(RVA = "0x465130", Offset = "0x464330", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002204")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A59")]
	public float NetworkmaxHealth
	{
		[Address(RVA = "0x465030", Offset = "0x464230", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F5")]
		 get { } //Length: 9
		[Address(RVA = "0x4651F0", Offset = "0x4643F0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F6")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A5E")]
	public float NetworkmaxStamina
	{
		[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FF")]
		 get { } //Length: 9
		[Address(RVA = "0x4652B0", Offset = "0x4644B0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002200")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A61")]
	public float NetworkrespawnTime
	{
		[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002205")]
		 get { } //Length: 9
		[Address(RVA = "0x465370", Offset = "0x464570", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002206")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A5B")]
	public float NetworksprintSpeed
	{
		[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F9")]
		 get { } //Length: 9
		[Address(RVA = "0x465430", Offset = "0x464630", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FA")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A5D")]
	public float Networkstamina
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FD")]
		 get { } //Length: 9
		[Address(RVA = "0x465670", Offset = "0x464870", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FE")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A5C")]
	public bool NetworkstaminaEnabled
	{
		[Address(RVA = "0x465040", Offset = "0x464240", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FB")]
		 get { } //Length: 8
		[Address(RVA = "0x4654F0", Offset = "0x4646F0", Length = "0xB6")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021FC")]
		 set { } //Length: 182
	}

	[Token(Token = "0x17000A5F")]
	public float NetworkstaminaRegen
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002201")]
		 get { } //Length: 9
		[Address(RVA = "0x4655B0", Offset = "0x4647B0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6002202")]
		 set { } //Length: 180
	}

	[Token(Token = "0x17000A5A")]
	public float NetworkwalkSpeed
	{
		[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F7")]
		 get { } //Length: 9
		[Address(RVA = "0x465730", Offset = "0x464930", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021F8")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A57")]
	public float RespawnTime
	{
		[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021EB")]
		 get { } //Length: 9
		[Address(RVA = "0x465370", Offset = "0x464570", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021EC")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A51")]
	public float SprintSpeed
	{
		[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DF")]
		 get { } //Length: 9
		[Address(RVA = "0x465430", Offset = "0x464630", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E0")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A53")]
	public float Stamina
	{
		[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E3")]
		 get { } //Length: 9
		[Address(RVA = "0x465670", Offset = "0x464870", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E4")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A52")]
	public bool StaminaEnabled
	{
		[Address(RVA = "0x465040", Offset = "0x464240", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E1")]
		 get { } //Length: 8
		[Address(RVA = "0x4654F0", Offset = "0x4646F0", Length = "0xB6")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E2")]
		 set { } //Length: 182
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A55")]
	public float StaminaRegen
	{
		[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E7")]
		 get { } //Length: 9
		[Address(RVA = "0x4655B0", Offset = "0x4647B0", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021E8")]
		 set { } //Length: 180
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000A50")]
	public float WalkSpeed
	{
		[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DD")]
		 get { } //Length: 9
		[Address(RVA = "0x465730", Offset = "0x464930", Length = "0xB4")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60021DE")]
		 set { } //Length: 180
	}

	[Address(RVA = "0x464E90", Offset = "0x464090", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RemoteProcedureCalls), Member = "RegisterCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(RemoteCallDelegate), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600220B")]
	private static PlayerDefaults() { }

	[Address(RVA = "0x464F70", Offset = "0x464170", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60021F3")]
	public PlayerDefaults() { }

	[Address(RVA = "0x42DC00", Offset = "0x42CE00", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "Awake", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EF")]
	protected virtual void Awake() { }

	[Address(RVA = "0x463F50", Offset = "0x463150", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteNetworkBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(NetworkBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Command(requiresAuthority = False)]
	[Token(Token = "0x60021F2")]
	private void CmdLoadDefaults(Player player) { }

	[Address(RVA = "0x4640C0", Offset = "0x4632C0", Length = "0x408")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600220D")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021ED")]
	public Color get_ChatColor() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E9")]
	public float get_JumpPower() { }

	[Address(RVA = "0x465030", Offset = "0x464230", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DB")]
	public float get_MaxHealth() { }

	[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E5")]
	public float get_MaxStamina() { }

	[Address(RVA = "0x465020", Offset = "0x464220", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002207")]
	public Color get_NetworkchatColor() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002203")]
	public float get_NetworkjumpPower() { }

	[Address(RVA = "0x465030", Offset = "0x464230", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F5")]
	public float get_NetworkmaxHealth() { }

	[Address(RVA = "0x420990", Offset = "0x41FB90", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FF")]
	public float get_NetworkmaxStamina() { }

	[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002205")]
	public float get_NetworkrespawnTime() { }

	[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F9")]
	public float get_NetworksprintSpeed() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FD")]
	public float get_Networkstamina() { }

	[Address(RVA = "0x465040", Offset = "0x464240", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FB")]
	public bool get_NetworkstaminaEnabled() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002201")]
	public float get_NetworkstaminaRegen() { }

	[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F7")]
	public float get_NetworkwalkSpeed() { }

	[Address(RVA = "0x460150", Offset = "0x45F350", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EB")]
	public float get_RespawnTime() { }

	[Address(RVA = "0x43D500", Offset = "0x43C700", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DF")]
	public float get_SprintSpeed() { }

	[Address(RVA = "0x402160", Offset = "0x401360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E3")]
	public float get_Stamina() { }

	[Address(RVA = "0x465040", Offset = "0x464240", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E1")]
	public bool get_StaminaEnabled() { }

	[Address(RVA = "0x420980", Offset = "0x41FB80", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E7")]
	public float get_StaminaRegen() { }

	[Address(RVA = "0x465050", Offset = "0x464250", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DD")]
	public float get_WalkSpeed() { }

	[Address(RVA = "0x4644D0", Offset = "0x4636D0", Length = "0x14C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadNetworkBehaviour", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = "T")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600220A")]
	protected static void InvokeUserCode_CmdLoadDefaults__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection) { }

	[Address(RVA = "0x464620", Offset = "0x463820", Length = "0x4DE")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<PostPlayerLoad>d__194", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Player), Member = "ServerRespawn", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PlayerDefaults), Member = "UserCode_CmdLoadDefaults__Player", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Player), Member = "set_StaminaEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_RespawnTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_ChatColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Instance), Member = "GetChildrenOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Instance), Member = "Clone", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Player), Member = "set_JumpPower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(Player), Member = "set_StaminaRegen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Player), Member = "set_Stamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Player), Member = "set_SprintSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_WalkSpeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Player), Member = "set_MaxHealth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SendCommandInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(NetworkWriter), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteNetworkBehaviour", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(NetworkBehaviour)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Player), Member = "set_MaxStamina", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60021F1")]
	public void LoadDefaults(Player player) { }

	[Address(RVA = "0x464B00", Offset = "0x463D00", Length = "0x203")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600220C")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x465060", Offset = "0x464260", Length = "0xCA")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EE")]
	public void set_ChatColor(Color value) { }

	[Address(RVA = "0x465130", Offset = "0x464330", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EA")]
	public void set_JumpPower(float value) { }

	[Address(RVA = "0x4651F0", Offset = "0x4643F0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DC")]
	public void set_MaxHealth(float value) { }

	[Address(RVA = "0x4652B0", Offset = "0x4644B0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E6")]
	public void set_MaxStamina(float value) { }

	[Address(RVA = "0x465060", Offset = "0x464260", Length = "0xCA")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002208")]
	public void set_NetworkchatColor(in Color value) { }

	[Address(RVA = "0x465130", Offset = "0x464330", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002204")]
	public void set_NetworkjumpPower(in float value) { }

	[Address(RVA = "0x4651F0", Offset = "0x4643F0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F6")]
	public void set_NetworkmaxHealth(in float value) { }

	[Address(RVA = "0x4652B0", Offset = "0x4644B0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002200")]
	public void set_NetworkmaxStamina(in float value) { }

	[Address(RVA = "0x465370", Offset = "0x464570", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002206")]
	public void set_NetworkrespawnTime(in float value) { }

	[Address(RVA = "0x465430", Offset = "0x464630", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FA")]
	public void set_NetworksprintSpeed(in float value) { }

	[Address(RVA = "0x465670", Offset = "0x464870", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FE")]
	public void set_Networkstamina(in float value) { }

	[Address(RVA = "0x4654F0", Offset = "0x4646F0", Length = "0xB6")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021FC")]
	public void set_NetworkstaminaEnabled(in bool value) { }

	[Address(RVA = "0x4655B0", Offset = "0x4647B0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002202")]
	public void set_NetworkstaminaRegen(in float value) { }

	[Address(RVA = "0x465730", Offset = "0x464930", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F8")]
	public void set_NetworkwalkSpeed(in float value) { }

	[Address(RVA = "0x465370", Offset = "0x464570", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021EC")]
	public void set_RespawnTime(float value) { }

	[Address(RVA = "0x465430", Offset = "0x464630", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E0")]
	public void set_SprintSpeed(float value) { }

	[Address(RVA = "0x465670", Offset = "0x464870", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E4")]
	public void set_Stamina(float value) { }

	[Address(RVA = "0x4654F0", Offset = "0x4646F0", Length = "0xB6")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", "T&", typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E2")]
	public void set_StaminaEnabled(bool value) { }

	[Address(RVA = "0x4655B0", Offset = "0x4647B0", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021E8")]
	public void set_StaminaRegen(float value) { }

	[Address(RVA = "0x465730", Offset = "0x464930", Length = "0xB4")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SyncVarEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "SetSyncVar", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Single&), typeof(ulong)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DE")]
	public void set_WalkSpeed(float value) { }

	[Address(RVA = "0x464D10", Offset = "0x463F10", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Instance), Member = "FindChildOfType", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Transform)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(NetworkServer), Member = "Spawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60021F0")]
	protected virtual void Start() { }

	[Address(RVA = "0x464E80", Offset = "0x464080", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerDefaults), Member = "LoadDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Player)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002209")]
	protected void UserCode_CmdLoadDefaults__Player(Player player) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021F4")]
	public virtual bool Weaved() { }

}

