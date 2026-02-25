namespace Unity.Properties.Internal;

[Token(Token = "0x2000092")]
internal class BoundsPropertyBag : ContainerPropertyBag<Bounds>
{
	[Token(Token = "0x2000093")]
	private class CenterProperty : Property<Bounds, Vector3>
	{

		[Token(Token = "0x17000086")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002F7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000085")]
		public virtual string Name
		{
			[Address(RVA = "0x19F5270", Offset = "0x19F4470", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002F6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F5230", Offset = "0x19F4430", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002FA")]
		public CenterProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F5270", Offset = "0x19F4470", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002F6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F51F0", Offset = "0x19F43F0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F8")]
		public virtual Vector3 GetValue(ref Bounds container) { }

		[Address(RVA = "0x19F5210", Offset = "0x19F4410", Length = "0x11")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002F9")]
		public virtual void SetValue(ref Bounds container, Vector3 value) { }

	}

	[Token(Token = "0x2000094")]
	private class ExtentsProperty : Property<Bounds, Vector3>
	{

		[Token(Token = "0x17000088")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60002FC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000087")]
		public virtual string Name
		{
			[Address(RVA = "0x19F5A00", Offset = "0x19F4C00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60002FB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x19F59C0", Offset = "0x19F4BC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60002FF")]
		public ExtentsProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x19F5A00", Offset = "0x19F4C00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60002FB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x19F5980", Offset = "0x19F4B80", Length = "0x17")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FD")]
		public virtual Vector3 GetValue(ref Bounds container) { }

		[Address(RVA = "0x19F59A0", Offset = "0x19F4BA0", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002FE")]
		public virtual void SetValue(ref Bounds container, Vector3 value) { }

	}


	[Address(RVA = "0x19F4FF0", Offset = "0x19F41F0", Length = "0x11F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60002F5")]
	public BoundsPropertyBag() { }

}

