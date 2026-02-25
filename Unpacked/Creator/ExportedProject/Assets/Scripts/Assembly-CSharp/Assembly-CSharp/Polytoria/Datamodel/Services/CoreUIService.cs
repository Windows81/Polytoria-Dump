namespace Polytoria.Datamodel.Services;

[Token(Token = "0x2000379")]
public class CoreUIService : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x4000F29")]
	private static CoreUIService <Instance>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000F2A")]
	private GameObject userCard; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000F2B")]
	private GameObject chat; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000F2C")]
	private GameObject healthBar; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000F2D")]
	private GameObject leaderboard; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000F2E")]
	private GameObject hotbar; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000F2F")]
	private GameObject menuButton; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000F30")]
	private GameObject chatButton; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000F31")]
	private Button resetButton; //Field offset: 0x58

	[Token(Token = "0x17000B3B")]
	public bool CanRespawn
	{
		[Address(RVA = "0x484A70", Offset = "0x483C70", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_CanRespawn", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600259B")]
		 get { } //Length: 30
		[Address(RVA = "0x484B90", Offset = "0x483D90", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_CanRespawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600259C")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B36")]
	public bool ChatEnabled
	{
		[Address(RVA = "0x484A90", Offset = "0x483C90", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_ChatEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002591")]
		 get { } //Length: 29
		[Address(RVA = "0x484BB0", Offset = "0x483DB0", Length = "0x44")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_ChatEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002592")]
		 set { } //Length: 68
	}

	[Token(Token = "0x17000B37")]
	public bool HealthBarEnabled
	{
		[Address(RVA = "0x484AB0", Offset = "0x483CB0", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_HealthBarEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002593")]
		 get { } //Length: 29
		[Address(RVA = "0x484C00", Offset = "0x483E00", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_HealthBarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002594")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B39")]
	public bool HotbarEnabled
	{
		[Address(RVA = "0x484AD0", Offset = "0x483CD0", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_HotbarEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002597")]
		 get { } //Length: 29
		[Address(RVA = "0x484C20", Offset = "0x483E20", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_HotbarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002598")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B34")]
	public private static CoreUIService Instance
	{
		[Address(RVA = "0x484AF0", Offset = "0x483CF0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x600258D")]
		 get { } //Length: 54
		[Address(RVA = "0x484C40", Offset = "0x483E40", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x600258E")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000B38")]
	public bool LeaderboardEnabled
	{
		[Address(RVA = "0x484B30", Offset = "0x483D30", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_LeaderboardEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002595")]
		 get { } //Length: 29
		[Address(RVA = "0x484CA0", Offset = "0x483EA0", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_LeaderboardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002596")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B3A")]
	public bool MenuButtonEnabled
	{
		[Address(RVA = "0x484B50", Offset = "0x483D50", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_MenuButtonEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002599")]
		 get { } //Length: 29
		[Address(RVA = "0x484CC0", Offset = "0x483EC0", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_MenuButtonEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600259A")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000B35")]
	public bool UserCardEnabled
	{
		[Address(RVA = "0x484B70", Offset = "0x483D70", Length = "0x1D")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_UserCardEnabled", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600258F")]
		 get { } //Length: 29
		[Address(RVA = "0x484CE0", Offset = "0x483EE0", Length = "0x1E")]
		[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_UserCardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002590")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600259E")]
	public CoreUIService() { }

	[Address(RVA = "0x484A10", Offset = "0x483C10", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600259D")]
	private void Awake() { }

	[Address(RVA = "0x484A70", Offset = "0x483C70", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_CanRespawn", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600259B")]
	public bool get_CanRespawn() { }

	[Address(RVA = "0x484A90", Offset = "0x483C90", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_ChatEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002591")]
	public bool get_ChatEnabled() { }

	[Address(RVA = "0x484AB0", Offset = "0x483CB0", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_HealthBarEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002593")]
	public bool get_HealthBarEnabled() { }

	[Address(RVA = "0x484AD0", Offset = "0x483CD0", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_HotbarEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002597")]
	public bool get_HotbarEnabled() { }

	[Address(RVA = "0x484AF0", Offset = "0x483CF0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x600258D")]
	public static CoreUIService get_Instance() { }

	[Address(RVA = "0x484B30", Offset = "0x483D30", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_LeaderboardEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002595")]
	public bool get_LeaderboardEnabled() { }

	[Address(RVA = "0x484B50", Offset = "0x483D50", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_MenuButtonEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002599")]
	public bool get_MenuButtonEnabled() { }

	[Address(RVA = "0x484B70", Offset = "0x483D70", Length = "0x1D")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "get_UserCardEnabled", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600258F")]
	public bool get_UserCardEnabled() { }

	[Address(RVA = "0x484B90", Offset = "0x483D90", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_CanRespawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600259C")]
	public void set_CanRespawn(bool value) { }

	[Address(RVA = "0x484BB0", Offset = "0x483DB0", Length = "0x44")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_ChatEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002592")]
	public void set_ChatEnabled(bool value) { }

	[Address(RVA = "0x484C00", Offset = "0x483E00", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_HealthBarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002594")]
	public void set_HealthBarEnabled(bool value) { }

	[Address(RVA = "0x484C20", Offset = "0x483E20", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_HotbarEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002598")]
	public void set_HotbarEnabled(bool value) { }

	[Address(RVA = "0x484C40", Offset = "0x483E40", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x600258E")]
	private static void set_Instance(CoreUIService value) { }

	[Address(RVA = "0x484CA0", Offset = "0x483EA0", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_LeaderboardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002596")]
	public void set_LeaderboardEnabled(bool value) { }

	[Address(RVA = "0x484CC0", Offset = "0x483EC0", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_MenuButtonEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600259A")]
	public void set_MenuButtonEnabled(bool value) { }

	[Address(RVA = "0x484CE0", Offset = "0x483EE0", Length = "0x1E")]
	[CalledBy(Type = typeof(CoreUIServiceProxy), Member = "set_UserCardEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002590")]
	public void set_UserCardEnabled(bool value) { }

}

