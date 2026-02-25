namespace SimpleJSON;

[DefaultMember("Item")]
[Token(Token = "0x200002F")]
public class JSONArray : JSONNode
{
	[CompilerGenerated]
	[Token(Token = "0x2000030")]
	private sealed class <get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017B")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400017C")]
		private JSONNode <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400017D")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400017E")]
		public JSONArray <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400017F")]
		private Enumerator<JSONNode> <>7__wrap1; //Field offset: 0x30

		[Token(Token = "0x1700005A")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000400")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700005B")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DebuggerHidden]
			[DeduplicatedMethod]
			[Token(Token = "0x6000402")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x313540", Offset = "0x312740", Length = "0x2E")]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x60003FC")]
		public <get_Children>d__22(int <>1__state) { }

		[Address(RVA = "0x314790", Offset = "0x313990", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003FF")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x314470", Offset = "0x313670", Length = "0x1A9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F57F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003FE")]
		private override bool MoveNext() { }

		[Address(RVA = "0x314620", Offset = "0x313820", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000403")]
		private override IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000400")]
		private override JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current() { }

		[Address(RVA = "0x314620", Offset = "0x313820", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000404")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000402")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x3146C0", Offset = "0x3138C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DebuggerHidden]
		[Token(Token = "0x6000401")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x314700", Offset = "0x313900", Length = "0x83")]
		[CalledBy(Type = typeof(UnitySourceGeneratedAssemblyMonoScriptTypes_v1), Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802F58D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DebuggerHidden]
		[Token(Token = "0x60003FD")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000179")]
	private List<JSONNode> m_List; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400017A")]
	private bool inline; //Field offset: 0x18

	[Token(Token = "0x17000059")]
	public virtual IEnumerable<JSONNode> Children
	{
		[Address(RVA = "0x2FE2D0", Offset = "0x2FD4D0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 2)]
		[IteratorStateMachine(typeof(<get_Children>d__22))]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 113
	}

	[Token(Token = "0x17000058")]
	public virtual int Count
	{
		[Address(RVA = "0x2FE350", Offset = "0x2FD550", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60003F5")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000053")]
	public virtual bool Inline
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EC")]
		 get { } //Length: 5
		[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003ED")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000055")]
	public virtual bool IsArray
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EF")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000056")]
	public virtual JSONNode Item
	{
		[Address(RVA = "0x2FE3A0", Offset = "0x2FD5A0", Length = "0xBF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x60003F1")]
		 get { } //Length: 191
		[Address(RVA = "0x2FE500", Offset = "0x2FD700", Length = "0x147")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60003F2")]
		 set { } //Length: 327
	}

	[Token(Token = "0x17000057")]
	public virtual JSONNode Item
	{
		[Address(RVA = "0x2FE460", Offset = "0x2FD660", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60003F3")]
		 get { } //Length: 115
		[Address(RVA = "0x2FE650", Offset = "0x2FD850", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60003F4")]
		 set { } //Length: 229
	}

	[Token(Token = "0x17000054")]
	public virtual JSONNodeType Tag
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x60003EE")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2FE250", Offset = "0x2FD450", Length = "0x77")]
	[CalledBy(Type = typeof(JSONNode), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONNode), Member = "GetContainer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONContainerType)}, ReturnType = typeof(JSONNode))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(JSONLazyCreator), Member = "get_AsArray", ReturnType = typeof(JSONArray))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003FB")]
	public JSONArray() { }

	[Address(RVA = "0x2FDE40", Offset = "0x2FD040", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F6")]
	public virtual void Add(string aKey, JSONNode aItem) { }

	[Address(RVA = "0x2FE2D0", Offset = "0x2FD4D0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[IteratorStateMachine(typeof(<get_Children>d__22))]
	[Token(Token = "0x60003F9")]
	public virtual IEnumerable<JSONNode> get_Children() { }

	[Address(RVA = "0x2FE350", Offset = "0x2FD550", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F5")]
	public virtual int get_Count() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EC")]
	public virtual bool get_Inline() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EF")]
	public virtual bool get_IsArray() { }

	[Address(RVA = "0x2FE3A0", Offset = "0x2FD5A0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60003F1")]
	public virtual JSONNode get_Item(int aIndex) { }

	[Address(RVA = "0x2FE460", Offset = "0x2FD660", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F3")]
	public virtual JSONNode get_Item(string aKey) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003EE")]
	public virtual JSONNodeType get_Tag() { }

	[Address(RVA = "0x2FDF30", Offset = "0x2FD130", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F0")]
	public virtual Enumerator GetEnumerator() { }

	[Address(RVA = "0x2FDFD0", Offset = "0x2FD1D0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F7")]
	public virtual JSONNode Remove(int aIndex) { }

	[Address(RVA = "0x2FE080", Offset = "0x2FD280", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60003F8")]
	public virtual JSONNode Remove(JSONNode aNode) { }

	[Address(RVA = "0x2FE4F0", Offset = "0x2FD6F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60003ED")]
	public virtual void set_Inline(bool value) { }

	[Address(RVA = "0x2FE500", Offset = "0x2FD700", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F2")]
	public virtual void set_Item(int aIndex, JSONNode value) { }

	[Address(RVA = "0x2FE650", Offset = "0x2FD850", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(JSONNode), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JSONNode), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(JSONNull), Member = "CreateOrGet", ReturnType = typeof(JSONNull))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60003F4")]
	public virtual void set_Item(string aKey, JSONNode value) { }

	[Address(RVA = "0x2FE0E0", Offset = "0x2FD2E0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002390")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003FA")]
	internal virtual void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode) { }

}

