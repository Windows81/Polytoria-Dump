namespace Polytoria.Datamodel.Proxies;

[DefaultMember("Item")]
[Token(Token = "0x20003A7")]
public class InstanceProxy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000FF1")]
	private readonly Instance target; //Field offset: 0x10

	[LuaEventParameter(typeof(Instance), "child", False)]
	[Token(Token = "0x17000BAA")]
	public LuaEvent ChildAdded
	{
		[Address(RVA = "0x4A5640", Offset = "0x4A4840", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002760")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "child", False)]
	[Token(Token = "0x17000BA9")]
	public LuaEvent ChildRemoved
	{
		[Address(RVA = "0x4A5660", Offset = "0x4A4860", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275F")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BA5")]
	public string ClassName
	{
		[Address(RVA = "0x4A5680", Offset = "0x4A4880", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275A")]
		 get { } //Length: 27
	}

	[LuaEventParameter(typeof(Player), "player", False)]
	[Token(Token = "0x17000BAD")]
	public LuaEvent Clicked
	{
		[Address(RVA = "0x4A56A0", Offset = "0x4A48A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002763")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BA7")]
	public bool ClientSpawned
	{
		[Address(RVA = "0x4A56C0", Offset = "0x4A48C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275C")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BA2")]
	public Instance Item
	{
		[Address(RVA = "0x4A5700", Offset = "0x4A4900", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002756")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BA3")]
	public Instance Item
	{
		[Address(RVA = "0x4A56E0", Offset = "0x4A48E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instance))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002757")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BAE")]
	public LuaEvent MouseEnter
	{
		[Address(RVA = "0x4A5720", Offset = "0x4A4920", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002764")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BAF")]
	public LuaEvent MouseExit
	{
		[Address(RVA = "0x4A5740", Offset = "0x4A4940", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002765")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000BA4")]
	public string Name
	{
		[Address(RVA = "0x4A5760", Offset = "0x4A4960", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002758")]
		 get { } //Length: 27
		[Address(RVA = "0x4A5800", Offset = "0x4A4A00", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002759")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BA8")]
	public Instance Parent
	{
		[Address(RVA = "0x4A5780", Offset = "0x4A4980", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275D")]
		 get { } //Length: 29
		[Address(RVA = "0x4A5820", Offset = "0x4A4A20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275E")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BA6")]
	public DynValue Shared
	{
		[Address(RVA = "0x4A57A0", Offset = "0x4A49A0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600275B")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "other", False)]
	[Token(Token = "0x17000BAB")]
	public LuaEvent Touched
	{
		[Address(RVA = "0x4A57E0", Offset = "0x4A49E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002761")]
		 get { } //Length: 30
	}

	[LuaEventParameter(typeof(Instance), "other", False)]
	[Token(Token = "0x17000BAC")]
	public LuaEvent TouchEnded
	{
		[Address(RVA = "0x4A57C0", Offset = "0x4A49C0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002762")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002755")]
	public InstanceProxy(Instance target) { }

	[Address(RVA = "0x4A5450", Offset = "0x4A4650", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "Clone", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002771")]
	public Instance Clone() { }

	[Address(RVA = "0x4A5470", Offset = "0x4A4670", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600276F")]
	public void Delete(float time = 0) { }

	[Address(RVA = "0x4A5470", Offset = "0x4A4670", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600276E")]
	public void Destroy(float time = 0) { }

	[Address(RVA = "0x4A54B0", Offset = "0x4A46B0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "FindChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002768")]
	public Instance FindChild(string name) { }

	[Address(RVA = "0x4A5490", Offset = "0x4A4690", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "FindChildByClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600276B")]
	public Instance FindChildByClass(string className) { }

	[Address(RVA = "0x4A5640", Offset = "0x4A4840", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002760")]
	public LuaEvent get_ChildAdded() { }

	[Address(RVA = "0x4A5660", Offset = "0x4A4860", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275F")]
	public LuaEvent get_ChildRemoved() { }

	[Address(RVA = "0x4A5680", Offset = "0x4A4880", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275A")]
	public string get_ClassName() { }

	[Address(RVA = "0x4A56A0", Offset = "0x4A48A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002763")]
	public LuaEvent get_Clicked() { }

	[Address(RVA = "0x4A56C0", Offset = "0x4A48C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275C")]
	public bool get_ClientSpawned() { }

	[Address(RVA = "0x4A5700", Offset = "0x4A4900", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002756")]
	public Instance get_Item(string name) { }

	[Address(RVA = "0x4A56E0", Offset = "0x4A48E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002757")]
	public Instance get_Item(int index) { }

	[Address(RVA = "0x4A5720", Offset = "0x4A4920", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002764")]
	public LuaEvent get_MouseEnter() { }

	[Address(RVA = "0x4A5740", Offset = "0x4A4940", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002765")]
	public LuaEvent get_MouseExit() { }

	[Address(RVA = "0x4A5760", Offset = "0x4A4960", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002758")]
	public string get_Name() { }

	[Address(RVA = "0x4A5780", Offset = "0x4A4980", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275D")]
	public Instance get_Parent() { }

	[Address(RVA = "0x4A57A0", Offset = "0x4A49A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275B")]
	public DynValue get_Shared() { }

	[Address(RVA = "0x4A57E0", Offset = "0x4A49E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002761")]
	public LuaEvent get_Touched() { }

	[Address(RVA = "0x4A57C0", Offset = "0x4A49C0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002762")]
	public LuaEvent get_TouchEnded() { }

	[Address(RVA = "0x4A54D0", Offset = "0x4A46D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "GetBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoundsCalculationMethod)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002772")]
	public Bounds GetBounds() { }

	[Address(RVA = "0x4A5540", Offset = "0x4A4740", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "GetChildren", ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002769")]
	public Instance[] GetChildren() { }

	[Address(RVA = "0x4A5520", Offset = "0x4A4720", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "GetChildrenOfClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Instance[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600276A")]
	public Instance[] GetChildrenOfClass(string className) { }

	[Address(RVA = "0x4A5560", Offset = "0x4A4760", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "GetParent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002766")]
	public Instance GetParent() { }

	[Address(RVA = "0x4A5580", Offset = "0x4A4780", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "IsA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600276C")]
	public bool IsA(string className) { }

	[Address(RVA = "0x4A55A0", Offset = "0x4A47A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "IsDescendantOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600276D")]
	public bool IsDescendantOf(Instance parent) { }

	[Address(RVA = "0x4A55C0", Offset = "0x4A47C0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Instance), Member = "New", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Instance)}, ReturnType = typeof(Instance))]
	[Token(Token = "0x6002770")]
	public static Instance New(string className, Instance parent = null) { }

	[Address(RVA = "0x4A5800", Offset = "0x4A4A00", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002759")]
	public void set_Name(string value) { }

	[Address(RVA = "0x4A5820", Offset = "0x4A4A20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "set_Parent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600275E")]
	public void set_Parent(Instance value) { }

	[Address(RVA = "0x4A5620", Offset = "0x4A4820", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002767")]
	public void SetParent(Instance parent) { }

}

