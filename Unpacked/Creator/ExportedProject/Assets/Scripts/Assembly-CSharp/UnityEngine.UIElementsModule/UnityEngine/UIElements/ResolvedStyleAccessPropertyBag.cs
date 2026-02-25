namespace UnityEngine.UIElements;

[Token(Token = "0x200037D")]
internal class ResolvedStyleAccessPropertyBag : PropertyBag<ResolvedStyleAccess>, INamedProperties<ResolvedStyleAccess>
{
	[Token(Token = "0x200037E")]
	private class AlignContentProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x17000763")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B89")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000761")]
		public virtual string Name
		{
			[Address(RVA = "0x1B07460", Offset = "0x1B06660", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B87")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000762")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B07490", Offset = "0x1B06690", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B88")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07420", Offset = "0x1B06620", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B8C")]
		public AlignContentProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B89")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B07460", Offset = "0x1B06660", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B87")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B07490", Offset = "0x1B06690", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B88")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07390", Offset = "0x1B06590", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B8A")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B073E0", Offset = "0x1B065E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B8B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x200037F")]
	private class AlignItemsProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x17000766")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B8F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000764")]
		public virtual string Name
		{
			[Address(RVA = "0x1B07590", Offset = "0x1B06790", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B8D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000765")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B075C0", Offset = "0x1B067C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B8E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07550", Offset = "0x1B06750", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B92")]
		public AlignItemsProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B8F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B07590", Offset = "0x1B06790", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B8D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B075C0", Offset = "0x1B067C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B8E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B074C0", Offset = "0x1B066C0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B90")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07510", Offset = "0x1B06710", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B91")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x2000380")]
	private class AlignSelfProperty : ResolvedEnumProperty<Align>
	{

		[Token(Token = "0x17000769")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B95")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000767")]
		public virtual string Name
		{
			[Address(RVA = "0x1B076C0", Offset = "0x1B068C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B93")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000768")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B076F0", Offset = "0x1B068F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B94")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07680", Offset = "0x1B06880", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001B98")]
		public AlignSelfProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B95")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B076C0", Offset = "0x1B068C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B93")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B076F0", Offset = "0x1B068F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B94")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B075F0", Offset = "0x1B067F0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001B96")]
		public virtual Align GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07640", Offset = "0x1B06840", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B97")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Align value) { }

	}

	[Token(Token = "0x2000381")]
	private class BackgroundColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x1700076C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001B9B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700076A")]
		public virtual string Name
		{
			[Address(RVA = "0x1B079A0", Offset = "0x1B06BA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B99")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700076B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B079D0", Offset = "0x1B06BD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B9A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B9E")]
		public BackgroundColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001B9B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B079A0", Offset = "0x1B06BA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B99")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B079D0", Offset = "0x1B06BD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B9A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07850", Offset = "0x1B06A50", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001B9C")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07920", Offset = "0x1B06B20", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001B9D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x2000382")]
	private class BackgroundImageProperty : ResolvedBackgroundProperty
	{

		[Token(Token = "0x1700076F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BA1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700076D")]
		public virtual string Name
		{
			[Address(RVA = "0x1B07B60", Offset = "0x1B06D60", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001B9F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700076E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B07B90", Offset = "0x1B06D90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BA0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07B20", Offset = "0x1B06D20", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA4")]
		public BackgroundImageProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B07B60", Offset = "0x1B06D60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001B9F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B07B90", Offset = "0x1B06D90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BA0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07A00", Offset = "0x1B06C00", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BA2")]
		public virtual Background GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07AE0", Offset = "0x1B06CE0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BA3")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Background value) { }

	}

	[Token(Token = "0x2000383")]
	private class BackgroundPositionXProperty : ResolvedBackgroundPositionProperty
	{

		[Token(Token = "0x17000772")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BA7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000770")]
		public virtual string Name
		{
			[Address(RVA = "0x1B07D20", Offset = "0x1B06F20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BA5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000771")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B07D50", Offset = "0x1B06F50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BA6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07CE0", Offset = "0x1B06EE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BAA")]
		public BackgroundPositionXProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BA7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B07D20", Offset = "0x1B06F20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BA5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B07D50", Offset = "0x1B06F50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BA6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07BC0", Offset = "0x1B06DC0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BA8")]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07CA0", Offset = "0x1B06EA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BA9")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	[Token(Token = "0x2000384")]
	private class BackgroundPositionYProperty : ResolvedBackgroundPositionProperty
	{

		[Token(Token = "0x17000775")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BAD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000773")]
		public virtual string Name
		{
			[Address(RVA = "0x1B07EA0", Offset = "0x1B070A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BAB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000774")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B07ED0", Offset = "0x1B070D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BAC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07CE0", Offset = "0x1B06EE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB0")]
		public BackgroundPositionYProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BAD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B07EA0", Offset = "0x1B070A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BAB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B07ED0", Offset = "0x1B070D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BAC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07D80", Offset = "0x1B06F80", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BAE")]
		public virtual BackgroundPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07E60", Offset = "0x1B07060", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BAF")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundPosition value) { }

	}

	[Token(Token = "0x2000385")]
	private class BackgroundRepeatProperty : ResolvedBackgroundRepeatProperty
	{

		[Token(Token = "0x17000778")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BB3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000776")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08040", Offset = "0x1B07240", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BB1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000777")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08070", Offset = "0x1B07270", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BB2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08000", Offset = "0x1B07200", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB6")]
		public BackgroundRepeatProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08040", Offset = "0x1B07240", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BB1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08070", Offset = "0x1B07270", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BB2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B07F00", Offset = "0x1B07100", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001BB4")]
		public virtual BackgroundRepeat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B07FC0", Offset = "0x1B071C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BB5")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundRepeat value) { }

	}

	[Token(Token = "0x2000386")]
	private class BackgroundSizeProperty : ResolvedBackgroundSizeProperty
	{

		[Token(Token = "0x1700077B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BB9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000779")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08200", Offset = "0x1B07400", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BB7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700077A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08230", Offset = "0x1B07430", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BB8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B081C0", Offset = "0x1B073C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BBC")]
		public BackgroundSizeProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BB9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08200", Offset = "0x1B07400", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BB7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08230", Offset = "0x1B07430", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BB8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B080A0", Offset = "0x1B072A0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BBA")]
		public virtual BackgroundSize GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08180", Offset = "0x1B07380", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BBB")]
		public virtual void SetValue(ref ResolvedStyleAccess container, BackgroundSize value) { }

	}

	[Token(Token = "0x2000387")]
	private class BorderBottomColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x1700077E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BBF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700077C")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08AE0", Offset = "0x1B07CE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BBD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700077D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08B10", Offset = "0x1B07D10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BBE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BC2")]
		public BorderBottomColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BBF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08AE0", Offset = "0x1B07CE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BBD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08B10", Offset = "0x1B07D10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BBE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B089D0", Offset = "0x1B07BD0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BC0")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08AA0", Offset = "0x1B07CA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BC1")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x2000388")]
	private class BorderBottomLeftRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000781")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BC5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700077F")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08C10", Offset = "0x1B07E10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BC3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000780")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08C40", Offset = "0x1B07E40", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BC4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BC8")]
		public BorderBottomLeftRadiusProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BC5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08C10", Offset = "0x1B07E10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BC3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08C40", Offset = "0x1B07E40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BC4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B08B40", Offset = "0x1B07D40", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BC6")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08B90", Offset = "0x1B07D90", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BC7")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000389")]
	private class BorderBottomRightRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000784")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BCB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000782")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08D00", Offset = "0x1B07F00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BC9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000783")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08D30", Offset = "0x1B07F30", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BCA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BCE")]
		public BorderBottomRightRadiusProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BCB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08D00", Offset = "0x1B07F00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BC9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08D30", Offset = "0x1B07F30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BCA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B08C70", Offset = "0x1B07E70", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BCC")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08CC0", Offset = "0x1B07EC0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BCD")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200038A")]
	private class BorderBottomWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000787")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BD1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000785")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08DF0", Offset = "0x1B07FF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BCF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000786")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08E20", Offset = "0x1B08020", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BD0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BD4")]
		public BorderBottomWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BD1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08DF0", Offset = "0x1B07FF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BCF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08E20", Offset = "0x1B08020", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BD0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B08D60", Offset = "0x1B07F60", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BD2")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08DB0", Offset = "0x1B07FB0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BD3")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200038B")]
	private class BorderLeftColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x1700078A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BD7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000788")]
		public virtual string Name
		{
			[Address(RVA = "0x1B08F60", Offset = "0x1B08160", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BD5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000789")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B08F90", Offset = "0x1B08190", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BD6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BDA")]
		public BorderLeftColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BD7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B08F60", Offset = "0x1B08160", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BD5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B08F90", Offset = "0x1B08190", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BD6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B08E50", Offset = "0x1B08050", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BD8")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B08F20", Offset = "0x1B08120", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BD9")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x200038C")]
	private class BorderLeftWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700078D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BDD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078B")]
		public virtual string Name
		{
			[Address(RVA = "0x1B09050", Offset = "0x1B08250", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BDB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700078C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09080", Offset = "0x1B08280", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BDC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BE0")]
		public BorderLeftWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BDD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B09050", Offset = "0x1B08250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BDB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09080", Offset = "0x1B08280", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BDC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B08FC0", Offset = "0x1B081C0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BDE")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B09010", Offset = "0x1B08210", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BDF")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200038D")]
	private class BorderRightColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x17000790")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BE3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700078E")]
		public virtual string Name
		{
			[Address(RVA = "0x1B091C0", Offset = "0x1B083C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BE1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700078F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B091F0", Offset = "0x1B083F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BE2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BE6")]
		public BorderRightColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BE3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B091C0", Offset = "0x1B083C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BE1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B091F0", Offset = "0x1B083F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BE2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B090B0", Offset = "0x1B082B0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BE4")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B09180", Offset = "0x1B08380", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BE5")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x200038E")]
	private class BorderRightWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000793")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BE9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000791")]
		public virtual string Name
		{
			[Address(RVA = "0x1B092B0", Offset = "0x1B084B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BE7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000792")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B092E0", Offset = "0x1B084E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BE8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BEC")]
		public BorderRightWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BE9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B092B0", Offset = "0x1B084B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BE7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B092E0", Offset = "0x1B084E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BE8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09220", Offset = "0x1B08420", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BEA")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B09270", Offset = "0x1B08470", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BEB")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200038F")]
	private class BorderTopColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x17000796")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BEF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000794")]
		public virtual string Name
		{
			[Address(RVA = "0x1B09420", Offset = "0x1B08620", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BED")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000795")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09450", Offset = "0x1B08650", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BEE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BF2")]
		public BorderTopColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BEF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B09420", Offset = "0x1B08620", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BED")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09450", Offset = "0x1B08650", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BEE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09310", Offset = "0x1B08510", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001BF0")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B093E0", Offset = "0x1B085E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BF1")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x2000390")]
	private class BorderTopLeftRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000799")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BF5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000797")]
		public virtual string Name
		{
			[Address(RVA = "0x1B09510", Offset = "0x1B08710", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BF3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000798")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09540", Offset = "0x1B08740", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BF4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BF8")]
		public BorderTopLeftRadiusProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BF5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B09510", Offset = "0x1B08710", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BF3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09540", Offset = "0x1B08740", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BF4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09480", Offset = "0x1B08680", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BF6")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B094D0", Offset = "0x1B086D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BF7")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000391")]
	private class BorderTopRightRadiusProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700079C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001BFB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700079A")]
		public virtual string Name
		{
			[Address(RVA = "0x1B09600", Offset = "0x1B08800", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BF9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700079B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09630", Offset = "0x1B08830", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BFA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BFE")]
		public BorderTopRightRadiusProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001BFB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B09600", Offset = "0x1B08800", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BF9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09630", Offset = "0x1B08830", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BFA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09570", Offset = "0x1B08770", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001BFC")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B095C0", Offset = "0x1B087C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001BFD")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000392")]
	private class BorderTopWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700079F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C01")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700079D")]
		public virtual string Name
		{
			[Address(RVA = "0x1B096F0", Offset = "0x1B088F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001BFF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700079E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09720", Offset = "0x1B08920", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C00")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C04")]
		public BorderTopWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C01")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B096F0", Offset = "0x1B088F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001BFF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09720", Offset = "0x1B08920", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C00")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09660", Offset = "0x1B08860", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C02")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B096B0", Offset = "0x1B088B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C03")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000393")]
	private class BottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007A2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C07")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A0")]
		public virtual string Name
		{
			[Address(RVA = "0x1B097E0", Offset = "0x1B089E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C05")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A1")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09810", Offset = "0x1B08A10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C06")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C0A")]
		public BottomProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C07")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B097E0", Offset = "0x1B089E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C05")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09810", Offset = "0x1B08A10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C06")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09750", Offset = "0x1B08950", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C08")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B097A0", Offset = "0x1B089A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C09")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000394")]
	private class ColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x170007A5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C0D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A3")]
		public virtual string Name
		{
			[Address(RVA = "0x1B09950", Offset = "0x1B08B50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C0B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A4")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B09980", Offset = "0x1B08B80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C0C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C10")]
		public ColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C0D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B09950", Offset = "0x1B08B50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C0B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B09980", Offset = "0x1B08B80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C0C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B09840", Offset = "0x1B08A40", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001C0E")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B09910", Offset = "0x1B08B10", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C0F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x2000395")]
	private class DisplayProperty : ResolvedEnumProperty<DisplayStyle>
	{

		[Token(Token = "0x170007A8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C13")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A6")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A370", Offset = "0x1B09570", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C11")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007A7")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A3A0", Offset = "0x1B095A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C12")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A330", Offset = "0x1B09530", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C16")]
		public DisplayProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C13")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A370", Offset = "0x1B09570", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C11")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A3A0", Offset = "0x1B095A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C12")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A2A0", Offset = "0x1B094A0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C14")]
		public virtual DisplayStyle GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A2F0", Offset = "0x1B094F0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C15")]
		public virtual void SetValue(ref ResolvedStyleAccess container, DisplayStyle value) { }

	}

	[Token(Token = "0x2000396")]
	private class FlexBasisProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007AB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C19")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007A9")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A580", Offset = "0x1B09780", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C17")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007AA")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A5B0", Offset = "0x1B097B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C18")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C1C")]
		public FlexBasisProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C19")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A580", Offset = "0x1B09780", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C17")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A5B0", Offset = "0x1B097B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C18")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A4B0", Offset = "0x1B096B0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C1A")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A500", Offset = "0x1B09700", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C1B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000397")]
	private class FlexDirectionProperty : ResolvedEnumProperty<FlexDirection>
	{

		[Token(Token = "0x170007AE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C1F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007AC")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A6B0", Offset = "0x1B098B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C1D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007AD")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A6E0", Offset = "0x1B098E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C1E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A670", Offset = "0x1B09870", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C22")]
		public FlexDirectionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C1F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A6B0", Offset = "0x1B098B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C1D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A6E0", Offset = "0x1B098E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C1E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A5E0", Offset = "0x1B097E0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C20")]
		public virtual FlexDirection GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A630", Offset = "0x1B09830", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C21")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FlexDirection value) { }

	}

	[Token(Token = "0x2000398")]
	private class FlexGrowProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007B1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C25")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007AF")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A7A0", Offset = "0x1B099A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C23")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B0")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A7D0", Offset = "0x1B099D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C24")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C28")]
		public FlexGrowProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C25")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A7A0", Offset = "0x1B099A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C23")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A7D0", Offset = "0x1B099D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C24")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A710", Offset = "0x1B09910", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C26")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A760", Offset = "0x1B09960", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C27")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x2000399")]
	private class FlexShrinkProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007B4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C2B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B2")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A890", Offset = "0x1B09A90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C29")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B3")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A8C0", Offset = "0x1B09AC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C2A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2E")]
		public FlexShrinkProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C2B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A890", Offset = "0x1B09A90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C29")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A8C0", Offset = "0x1B09AC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C2A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A800", Offset = "0x1B09A00", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C2C")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A850", Offset = "0x1B09A50", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C2D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200039A")]
	private class FlexWrapProperty : ResolvedEnumProperty<Wrap>
	{

		[Token(Token = "0x170007B7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C31")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B5")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0A9C0", Offset = "0x1B09BC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C2F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B6")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0A9F0", Offset = "0x1B09BF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C30")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A980", Offset = "0x1B09B80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C34")]
		public FlexWrapProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C31")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0A9C0", Offset = "0x1B09BC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C2F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0A9F0", Offset = "0x1B09BF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C30")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0A8F0", Offset = "0x1B09AF0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C32")]
		public virtual Wrap GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0A940", Offset = "0x1B09B40", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C33")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Wrap value) { }

	}

	[Token(Token = "0x200039B")]
	private class FontSizeProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007BA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C37")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007B8")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0AAB0", Offset = "0x1B09CB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C35")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007B9")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0AAE0", Offset = "0x1B09CE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C36")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C3A")]
		public FontSizeProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C37")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0AAB0", Offset = "0x1B09CB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C35")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0AAE0", Offset = "0x1B09CE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C36")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0AA20", Offset = "0x1B09C20", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C38")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0AA70", Offset = "0x1B09C70", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C39")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200039C")]
	private class HeightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007BD")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C3D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007BB")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0ABA0", Offset = "0x1B09DA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C3B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007BC")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0ABD0", Offset = "0x1B09DD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C3C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C40")]
		public HeightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C3D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0ABA0", Offset = "0x1B09DA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C3B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0ABD0", Offset = "0x1B09DD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C3C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0AB10", Offset = "0x1B09D10", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C3E")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0AB60", Offset = "0x1B09D60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C3F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200039D")]
	private class JustifyContentProperty : ResolvedEnumProperty<Justify>
	{

		[Token(Token = "0x170007C0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C43")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007BE")]
		public virtual string Name
		{
			[Address(RVA = "0x1B0D050", Offset = "0x1B0C250", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C41")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007BF")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B0D080", Offset = "0x1B0C280", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C42")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0D010", Offset = "0x1B0C210", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001C46")]
		public JustifyContentProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C43")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B0D050", Offset = "0x1B0C250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C41")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B0D080", Offset = "0x1B0C280", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C42")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B0CF80", Offset = "0x1B0C180", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C44")]
		public virtual Justify GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B0CFD0", Offset = "0x1B0C1D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C45")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Justify value) { }

	}

	[Token(Token = "0x200039E")]
	private class LeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C49")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C1")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10260", Offset = "0x1B0F460", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C47")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C2")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10290", Offset = "0x1B0F490", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C48")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C4C")]
		public LeftProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C49")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10260", Offset = "0x1B0F460", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C47")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10290", Offset = "0x1B0F490", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C48")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B101D0", Offset = "0x1B0F3D0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C4A")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10220", Offset = "0x1B0F420", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C4B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x200039F")]
	private class LetterSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C4F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C4")]
		public virtual string Name
		{
			[Address(RVA = "0x1B106B0", Offset = "0x1B0F8B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C4D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C5")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B106E0", Offset = "0x1B0F8E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C4E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C52")]
		public LetterSpacingProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C4F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B106B0", Offset = "0x1B0F8B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C4D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B106E0", Offset = "0x1B0F8E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C4E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10620", Offset = "0x1B0F820", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C50")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10670", Offset = "0x1B0F870", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C51")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A0")]
	private class MarginBottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007C9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C55")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007C7")]
		public virtual string Name
		{
			[Address(RVA = "0x1B107A0", Offset = "0x1B0F9A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C53")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007C8")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B107D0", Offset = "0x1B0F9D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C54")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C58")]
		public MarginBottomProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C55")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B107A0", Offset = "0x1B0F9A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C53")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B107D0", Offset = "0x1B0F9D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C54")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10710", Offset = "0x1B0F910", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C56")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10760", Offset = "0x1B0F960", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C57")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A1")]
	private class MarginLeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007CC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C5B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007CA")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10890", Offset = "0x1B0FA90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C59")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007CB")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B108C0", Offset = "0x1B0FAC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C5A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C5E")]
		public MarginLeftProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C5B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10890", Offset = "0x1B0FA90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C59")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B108C0", Offset = "0x1B0FAC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C5A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10800", Offset = "0x1B0FA00", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C5C")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10850", Offset = "0x1B0FA50", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C5D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A2")]
	private class MarginRightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007CF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C61")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007CD")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10980", Offset = "0x1B0FB80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C5F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007CE")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B109B0", Offset = "0x1B0FBB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C60")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C64")]
		public MarginRightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C61")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10980", Offset = "0x1B0FB80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C5F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B109B0", Offset = "0x1B0FBB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C60")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B108F0", Offset = "0x1B0FAF0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C62")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10940", Offset = "0x1B0FB40", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C63")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A3")]
	private class MarginTopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007D2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C67")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D0")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10A70", Offset = "0x1B0FC70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C65")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D1")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10AA0", Offset = "0x1B0FCA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C66")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C6A")]
		public MarginTopProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C67")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10A70", Offset = "0x1B0FC70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C65")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10AA0", Offset = "0x1B0FCA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C66")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B109E0", Offset = "0x1B0FBE0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C68")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10A30", Offset = "0x1B0FC30", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C69")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A4")]
	private class MaxHeightProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007D5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C6D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D3")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10B60", Offset = "0x1B0FD60", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C6B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D4")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10B90", Offset = "0x1B0FD90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C6C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C70")]
		public MaxHeightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C6D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10B60", Offset = "0x1B0FD60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C6B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10B90", Offset = "0x1B0FD90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C6C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10AD0", Offset = "0x1B0FCD0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C6E")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10B20", Offset = "0x1B0FD20", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C6F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003A5")]
	private class MaxWidthProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007D8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C73")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D6")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10C50", Offset = "0x1B0FE50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C71")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007D7")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10C80", Offset = "0x1B0FE80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C72")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C76")]
		public MaxWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C73")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10C50", Offset = "0x1B0FE50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C71")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10C80", Offset = "0x1B0FE80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C72")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10BC0", Offset = "0x1B0FDC0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C74")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10C10", Offset = "0x1B0FE10", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C75")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003A6")]
	private class MinHeightProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007DB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C79")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007D9")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10D40", Offset = "0x1B0FF40", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C77")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007DA")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10D70", Offset = "0x1B0FF70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C78")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C7C")]
		public MinHeightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C79")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10D40", Offset = "0x1B0FF40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C77")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10D70", Offset = "0x1B0FF70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C78")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10CB0", Offset = "0x1B0FEB0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C7A")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10D00", Offset = "0x1B0FF00", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C7B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003A7")]
	private class MinWidthProperty : ResolvedStyleFloatProperty
	{

		[Token(Token = "0x170007DE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C7F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007DC")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10E30", Offset = "0x1B10030", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C7D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007DD")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10E60", Offset = "0x1B10060", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C7E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C82")]
		public MinWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C7F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10E30", Offset = "0x1B10030", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C7D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10E60", Offset = "0x1B10060", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C7E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10DA0", Offset = "0x1B0FFA0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C80")]
		public virtual StyleFloat GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10DF0", Offset = "0x1B0FFF0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C81")]
		public virtual void SetValue(ref ResolvedStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x20003A8")]
	private class OpacityProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007E1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C85")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007DF")]
		public virtual string Name
		{
			[Address(RVA = "0x1B10F20", Offset = "0x1B10120", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C83")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E0")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B10F50", Offset = "0x1B10150", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C84")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C88")]
		public OpacityProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C85")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B10F20", Offset = "0x1B10120", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C83")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B10F50", Offset = "0x1B10150", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C84")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10E90", Offset = "0x1B10090", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C86")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10EE0", Offset = "0x1B100E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C87")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003A9")]
	private class PaddingBottomProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007E4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C8B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E2")]
		public virtual string Name
		{
			[Address(RVA = "0x1B11010", Offset = "0x1B10210", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C89")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E3")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B11040", Offset = "0x1B10240", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C8A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C8E")]
		public PaddingBottomProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C8B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B11010", Offset = "0x1B10210", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C89")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B11040", Offset = "0x1B10240", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C8A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B10F80", Offset = "0x1B10180", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C8C")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B10FD0", Offset = "0x1B101D0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C8D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AA")]
	private class PaddingLeftProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007E7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C91")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E5")]
		public virtual string Name
		{
			[Address(RVA = "0x1B11100", Offset = "0x1B10300", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C8F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E6")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B11130", Offset = "0x1B10330", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C90")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C94")]
		public PaddingLeftProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C91")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B11100", Offset = "0x1B10300", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C8F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B11130", Offset = "0x1B10330", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C90")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B11070", Offset = "0x1B10270", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C92")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B110C0", Offset = "0x1B102C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C93")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AB")]
	private class PaddingRightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007EA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C97")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007E8")]
		public virtual string Name
		{
			[Address(RVA = "0x1B111F0", Offset = "0x1B103F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C95")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007E9")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B11220", Offset = "0x1B10420", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C96")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C9A")]
		public PaddingRightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C97")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B111F0", Offset = "0x1B103F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C95")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B11220", Offset = "0x1B10420", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C96")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B11160", Offset = "0x1B10360", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C98")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B111B0", Offset = "0x1B103B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C99")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AC")]
	private class PaddingTopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007ED")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001C9D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007EB")]
		public virtual string Name
		{
			[Address(RVA = "0x1B112E0", Offset = "0x1B104E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C9B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007EC")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B11310", Offset = "0x1B10510", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001C9C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA0")]
		public PaddingTopProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001C9D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B112E0", Offset = "0x1B104E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C9B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B11310", Offset = "0x1B10510", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001C9C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B11250", Offset = "0x1B10450", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001C9E")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B112A0", Offset = "0x1B104A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001C9F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AD")]
	private class PositionProperty : ResolvedEnumProperty<Position>
	{

		[Token(Token = "0x170007F0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CA3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007EE")]
		public virtual string Name
		{
			[Address(RVA = "0x1B11410", Offset = "0x1B10610", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CA1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007EF")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B11440", Offset = "0x1B10640", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CA2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B113D0", Offset = "0x1B105D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CA6")]
		public PositionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B11410", Offset = "0x1B10610", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CA1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B11440", Offset = "0x1B10640", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CA2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B11340", Offset = "0x1B10540", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CA4")]
		public virtual Position GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B11390", Offset = "0x1B10590", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CA5")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Position value) { }

	}

	[Token(Token = "0x20003DB")]
	private abstract class ResolvedBackgroundPositionProperty : ResolvedStyleProperty<BackgroundPosition>
	{

		[Address(RVA = "0x1B07CE0", Offset = "0x1B06EE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D75")]
		protected ResolvedBackgroundPositionProperty() { }

	}

	[Token(Token = "0x20003D1")]
	private abstract class ResolvedBackgroundProperty : ResolvedStyleProperty<Background>
	{

		[Address(RVA = "0x1B07B20", Offset = "0x1B06D20", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6B")]
		protected ResolvedBackgroundProperty() { }

	}

	[Token(Token = "0x20003DC")]
	private abstract class ResolvedBackgroundRepeatProperty : ResolvedStyleProperty<BackgroundRepeat>
	{

		[Address(RVA = "0x1B08000", Offset = "0x1B07200", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D76")]
		protected ResolvedBackgroundRepeatProperty() { }

	}

	[Token(Token = "0x20003DD")]
	private abstract class ResolvedBackgroundSizeProperty : ResolvedStyleProperty<BackgroundSize>
	{

		[Address(RVA = "0x1B081C0", Offset = "0x1B073C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D77")]
		protected ResolvedBackgroundSizeProperty() { }

	}

	[Token(Token = "0x20003D0")]
	private abstract class ResolvedColorProperty : ResolvedStyleProperty<Color>
	{

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6A")]
		protected ResolvedColorProperty() { }

	}

	[Token(Token = "0x20003CF")]
	private abstract class ResolvedEnumProperty : ResolvedStyleProperty<TValue>
	{

		[Address(RVA = "0xF0D010", Offset = "0xF0C210", Length = "0x21")]
		[CallerCount(Count = 42)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D69")]
		protected ResolvedEnumProperty`1() { }

	}

	[Token(Token = "0x20003D2")]
	private abstract class ResolvedFloatProperty : ResolvedStyleProperty<Single>
	{

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6C")]
		protected ResolvedFloatProperty() { }

	}

	[Token(Token = "0x20003D6")]
	private abstract class ResolvedFontDefinitionProperty : ResolvedStyleProperty<FontDefinition>
	{

		[Address(RVA = "0x1B12640", Offset = "0x1B11840", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D70")]
		protected ResolvedFontDefinitionProperty() { }

	}

	[Token(Token = "0x20003D5")]
	private abstract class ResolvedFontProperty : ResolvedStyleProperty<Font>
	{

		[Address(RVA = "0x1B12680", Offset = "0x1B11880", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6F")]
		protected ResolvedFontProperty() { }

	}

	[Token(Token = "0x20003D7")]
	private abstract class ResolvedIntProperty : ResolvedStyleProperty<Int32>
	{

		[Address(RVA = "0x1B126C0", Offset = "0x1B118C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D71")]
		protected ResolvedIntProperty() { }

	}

	[Token(Token = "0x20003D4")]
	private abstract class ResolvedListProperty : ResolvedStyleProperty<IEnumerable`1<T>>
	{

		[Address(RVA = "0xF0D010", Offset = "0xF0C210", Length = "0x21")]
		[CallerCount(Count = 42)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6E")]
		protected ResolvedListProperty`1() { }

	}

	[Token(Token = "0x20003D8")]
	private abstract class ResolvedRotateProperty : ResolvedStyleProperty<Rotate>
	{

		[Address(RVA = "0x1B12700", Offset = "0x1B11900", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D72")]
		protected ResolvedRotateProperty() { }

	}

	[Token(Token = "0x20003D9")]
	private abstract class ResolvedScaleProperty : ResolvedStyleProperty<Scale>
	{

		[Address(RVA = "0x1B12740", Offset = "0x1B11940", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D73")]
		protected ResolvedScaleProperty() { }

	}

	[Token(Token = "0x20003D3")]
	private abstract class ResolvedStyleFloatProperty : ResolvedStyleProperty<StyleFloat>
	{

		[Address(RVA = "0x1B0A540", Offset = "0x1B09740", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D6D")]
		protected ResolvedStyleFloatProperty() { }

	}

	[Token(Token = "0x20003CE")]
	private abstract class ResolvedStyleProperty : Property<ResolvedStyleAccess, TValue>
	{

		[Token(Token = "0x17000851")]
		public abstract string ussName
		{
			[Token(Token = "0x6001D67")]
			 get { } //Length: 0
		}

		[Address(RVA = "0xF0D040", Offset = "0xF0C240", Length = "0x13")]
		[CallerCount(Count = 131)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D68")]
		protected ResolvedStyleProperty`1() { }

		[Token(Token = "0x6001D67")]
		public abstract string get_ussName() { }

	}

	[Token(Token = "0x20003DA")]
	private abstract class ResolvedVector3Property : ResolvedStyleProperty<Vector3>
	{

		[Address(RVA = "0x1B146B0", Offset = "0x1B138B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D74")]
		protected ResolvedVector3Property() { }

	}

	[Token(Token = "0x20003AE")]
	private class RightProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007F3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CA9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F1")]
		public virtual string Name
		{
			[Address(RVA = "0x1B14780", Offset = "0x1B13980", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CA7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F2")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B147B0", Offset = "0x1B139B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CA8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAC")]
		public RightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CA9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B14780", Offset = "0x1B13980", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CA7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B147B0", Offset = "0x1B139B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CA8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B146F0", Offset = "0x1B138F0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CAA")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B14740", Offset = "0x1B13940", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CAB")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003AF")]
	private class RotateProperty : ResolvedRotateProperty
	{

		[Token(Token = "0x170007F6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CAF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F4")]
		public virtual string Name
		{
			[Address(RVA = "0x1B14900", Offset = "0x1B13B00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CAD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F5")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B14930", Offset = "0x1B13B30", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CAE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B12700", Offset = "0x1B11900", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CB2")]
		public RotateProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CAF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B14900", Offset = "0x1B13B00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CAD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B14930", Offset = "0x1B13B30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CAE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B147E0", Offset = "0x1B139E0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CB0")]
		public virtual Rotate GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B148C0", Offset = "0x1B13AC0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CB1")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Rotate value) { }

	}

	[Token(Token = "0x20003B0")]
	private class ScaleProperty : ResolvedScaleProperty
	{

		[Token(Token = "0x170007F9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CB5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007F7")]
		public virtual string Name
		{
			[Address(RVA = "0x1B15160", Offset = "0x1B14360", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CB3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007F8")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B15190", Offset = "0x1B14390", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CB4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B12740", Offset = "0x1B11940", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CB8")]
		public ScaleProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CB5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B15160", Offset = "0x1B14360", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CB3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B15190", Offset = "0x1B14390", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CB4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B15050", Offset = "0x1B14250", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CB6")]
		public virtual Scale GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B15120", Offset = "0x1B14320", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CB7")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Scale value) { }

	}

	[Token(Token = "0x20003B1")]
	private class TextOverflowProperty : ResolvedEnumProperty<TextOverflow>
	{

		[Token(Token = "0x170007FC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CBB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007FA")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1B890", Offset = "0x1B1AA90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CB9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007FB")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1B8C0", Offset = "0x1B1AAC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CBA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1B850", Offset = "0x1B1AA50", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CBE")]
		public TextOverflowProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CBB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1B890", Offset = "0x1B1AA90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CB9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1B8C0", Offset = "0x1B1AAC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CBA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1B7C0", Offset = "0x1B1A9C0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CBC")]
		public virtual TextOverflow GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1B810", Offset = "0x1B1AA10", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CBD")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflow value) { }

	}

	[Token(Token = "0x20003B2")]
	private class TopProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x170007FF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CC1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170007FD")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1BBC0", Offset = "0x1B1ADC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CBF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170007FE")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1BBF0", Offset = "0x1B1ADF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CC0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC4")]
		public TopProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1BBC0", Offset = "0x1B1ADC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CBF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1BBF0", Offset = "0x1B1ADF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CC0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1BB30", Offset = "0x1B1AD30", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CC2")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1BB80", Offset = "0x1B1AD80", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CC3")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003B3")]
	private class TransformOriginProperty : ResolvedVector3Property
	{

		[Token(Token = "0x17000802")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CC7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000800")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1C3C0", Offset = "0x1B1B5C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CC5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000801")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1C3F0", Offset = "0x1B1B5F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CC6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B146B0", Offset = "0x1B138B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CCA")]
		public TransformOriginProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CC7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1C3C0", Offset = "0x1B1B5C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CC5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1C3F0", Offset = "0x1B1B5F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CC6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1C2A0", Offset = "0x1B1B4A0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CC8")]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1C380", Offset = "0x1B1B580", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CC9")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	[Token(Token = "0x20003B4")]
	private class TransitionDelayProperty : ResolvedListProperty<TimeValue>
	{

		[Token(Token = "0x17000805")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CCD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000803")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1D010", Offset = "0x1B1C210", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CCB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000804")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1D040", Offset = "0x1B1C240", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CCC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1CFD0", Offset = "0x1B1C1D0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CD0")]
		public TransitionDelayProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CCD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1D010", Offset = "0x1B1C210", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CCB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1D040", Offset = "0x1B1C240", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CCC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1CF40", Offset = "0x1B1C140", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CCE")]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1CF90", Offset = "0x1B1C190", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CCF")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	[Token(Token = "0x20003B5")]
	private class TransitionDurationProperty : ResolvedListProperty<TimeValue>
	{

		[Token(Token = "0x17000808")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CD3")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000806")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1D140", Offset = "0x1B1C340", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CD1")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000807")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1D170", Offset = "0x1B1C370", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CD2")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1D100", Offset = "0x1B1C300", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CD6")]
		public TransitionDurationProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD3")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1D140", Offset = "0x1B1C340", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CD1")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1D170", Offset = "0x1B1C370", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CD2")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1D070", Offset = "0x1B1C270", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CD4")]
		public virtual IEnumerable<TimeValue> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1D0C0", Offset = "0x1B1C2C0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CD5")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<TimeValue> value) { }

	}

	[Token(Token = "0x20003B6")]
	private class TransitionPropertyProperty : ResolvedListProperty<StylePropertyName>
	{

		[Token(Token = "0x1700080B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CD9")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000809")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1D270", Offset = "0x1B1C470", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CD7")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700080A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1D2A0", Offset = "0x1B1C4A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CD8")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1D230", Offset = "0x1B1C430", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CDC")]
		public TransitionPropertyProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CD9")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1D270", Offset = "0x1B1C470", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CD7")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1D2A0", Offset = "0x1B1C4A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CD8")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1D1A0", Offset = "0x1B1C3A0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CDA")]
		public virtual IEnumerable<StylePropertyName> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1D1F0", Offset = "0x1B1C3F0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CDB")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<StylePropertyName> value) { }

	}

	[Token(Token = "0x20003B7")]
	private class TransitionTimingFunctionProperty : ResolvedListProperty<EasingFunction>
	{

		[Token(Token = "0x1700080E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CDF")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700080C")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1D3A0", Offset = "0x1B1C5A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CDD")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700080D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1D3D0", Offset = "0x1B1C5D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CDE")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1D360", Offset = "0x1B1C560", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CE2")]
		public TransitionTimingFunctionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CDF")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1D3A0", Offset = "0x1B1C5A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CDD")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1D3D0", Offset = "0x1B1C5D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CDE")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1D2D0", Offset = "0x1B1C4D0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CE0")]
		public virtual IEnumerable<EasingFunction> GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1D320", Offset = "0x1B1C520", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CE1")]
		public virtual void SetValue(ref ResolvedStyleAccess container, IEnumerable<EasingFunction> value) { }

	}

	[Token(Token = "0x20003B8")]
	private class TranslateProperty : ResolvedVector3Property
	{

		[Token(Token = "0x17000811")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CE5")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700080F")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1D520", Offset = "0x1B1C720", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CE3")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000810")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1D550", Offset = "0x1B1C750", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CE4")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B146B0", Offset = "0x1B138B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CE8")]
		public TranslateProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CE5")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1D520", Offset = "0x1B1C720", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CE3")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1D550", Offset = "0x1B1C750", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CE4")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1D400", Offset = "0x1B1C600", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CE6")]
		public virtual Vector3 GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1D4E0", Offset = "0x1B1C6E0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CE7")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Vector3 value) { }

	}

	[Token(Token = "0x20003B9")]
	private class UnityBackgroundImageTintColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x17000814")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CEB")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000812")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1DEC0", Offset = "0x1B1D0C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CE9")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000813")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1DEF0", Offset = "0x1B1D0F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CEA")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CEE")]
		public UnityBackgroundImageTintColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CEB")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1DEC0", Offset = "0x1B1D0C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CE9")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1DEF0", Offset = "0x1B1D0F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CEA")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1DDB0", Offset = "0x1B1CFB0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CEC")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1DE80", Offset = "0x1B1D080", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CED")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003BA")]
	private class UnityEditorTextRenderingModeProperty : ResolvedEnumProperty<EditorTextRenderingMode>
	{

		[Token(Token = "0x17000817")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CF1")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000815")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1DFF0", Offset = "0x1B1D1F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CEF")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000816")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E020", Offset = "0x1B1D220", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CF0")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1DFB0", Offset = "0x1B1D1B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001CF4")]
		public UnityEditorTextRenderingModeProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CF1")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1DFF0", Offset = "0x1B1D1F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CEF")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E020", Offset = "0x1B1D220", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CF0")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1DF20", Offset = "0x1B1D120", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001CF2")]
		public virtual EditorTextRenderingMode GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1DF70", Offset = "0x1B1D170", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CF3")]
		public virtual void SetValue(ref ResolvedStyleAccess container, EditorTextRenderingMode value) { }

	}

	[Token(Token = "0x20003BC")]
	private class UnityFontDefinitionProperty : ResolvedFontDefinitionProperty
	{

		[Token(Token = "0x1700081D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CFD")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700081B")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E160", Offset = "0x1B1D360", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CFB")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700081C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E190", Offset = "0x1B1D390", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CFC")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B12640", Offset = "0x1B11840", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D00")]
		public UnityFontDefinitionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CFD")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E160", Offset = "0x1B1D360", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CFB")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E190", Offset = "0x1B1D390", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CFC")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E050", Offset = "0x1B1D250", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001CFE")]
		public virtual FontDefinition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E120", Offset = "0x1B1D320", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CFF")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontDefinition value) { }

	}

	[Token(Token = "0x20003BB")]
	private class UnityFontProperty : ResolvedFontProperty
	{

		[Token(Token = "0x1700081A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001CF7")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000818")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E2C0", Offset = "0x1B1D4C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CF5")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000819")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E2F0", Offset = "0x1B1D4F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001CF6")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B12680", Offset = "0x1B11880", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CFA")]
		public UnityFontProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001CF7")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E2C0", Offset = "0x1B1D4C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CF5")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E2F0", Offset = "0x1B1D4F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001CF6")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E1C0", Offset = "0x1B1D3C0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001CF8")]
		public virtual Font GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E280", Offset = "0x1B1D480", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001CF9")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Font value) { }

	}

	[Token(Token = "0x20003BD")]
	private class UnityFontStyleAndWeightProperty : ResolvedEnumProperty<FontStyle>
	{

		[Token(Token = "0x17000820")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D03")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700081E")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E3F0", Offset = "0x1B1D5F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D01")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700081F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E420", Offset = "0x1B1D620", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D02")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1E3B0", Offset = "0x1B1D5B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D06")]
		public UnityFontStyleAndWeightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D03")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E3F0", Offset = "0x1B1D5F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D01")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E420", Offset = "0x1B1D620", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D02")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E320", Offset = "0x1B1D520", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D04")]
		public virtual FontStyle GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E370", Offset = "0x1B1D570", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D05")]
		public virtual void SetValue(ref ResolvedStyleAccess container, FontStyle value) { }

	}

	[Token(Token = "0x20003BE")]
	private class UnityParagraphSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000823")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D09")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000821")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E4E0", Offset = "0x1B1D6E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D07")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000822")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E510", Offset = "0x1B1D710", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D08")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D0C")]
		public UnityParagraphSpacingProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D09")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E4E0", Offset = "0x1B1D6E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D07")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E510", Offset = "0x1B1D710", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D08")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E450", Offset = "0x1B1D650", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D0A")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E4A0", Offset = "0x1B1D6A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D0B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003BF")]
	private class UnitySliceBottomProperty : ResolvedIntProperty
	{

		[Token(Token = "0x17000826")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D0F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000824")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E5D0", Offset = "0x1B1D7D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D0D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000825")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E600", Offset = "0x1B1D800", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D0E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B126C0", Offset = "0x1B118C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D12")]
		public UnitySliceBottomProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D0F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E5D0", Offset = "0x1B1D7D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D0D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E600", Offset = "0x1B1D800", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D0E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E540", Offset = "0x1B1D740", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D10")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E590", Offset = "0x1B1D790", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D11")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003C0")]
	private class UnitySliceLeftProperty : ResolvedIntProperty
	{

		[Token(Token = "0x17000829")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D15")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000827")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E6C0", Offset = "0x1B1D8C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D13")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000828")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E6F0", Offset = "0x1B1D8F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D14")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B126C0", Offset = "0x1B118C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D18")]
		public UnitySliceLeftProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D15")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E6C0", Offset = "0x1B1D8C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D13")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E6F0", Offset = "0x1B1D8F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D14")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E630", Offset = "0x1B1D830", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D16")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E680", Offset = "0x1B1D880", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D17")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003C1")]
	private class UnitySliceRightProperty : ResolvedIntProperty
	{

		[Token(Token = "0x1700082C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D1B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700082A")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E7B0", Offset = "0x1B1D9B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D19")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700082B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E7E0", Offset = "0x1B1D9E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D1A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B126C0", Offset = "0x1B118C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D1E")]
		public UnitySliceRightProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D1B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E7B0", Offset = "0x1B1D9B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D19")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E7E0", Offset = "0x1B1D9E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D1A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E720", Offset = "0x1B1D920", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D1C")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E770", Offset = "0x1B1D970", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D1D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003C2")]
	private class UnitySliceScaleProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700082F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D21")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700082D")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E8A0", Offset = "0x1B1DAA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D1F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700082E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E8D0", Offset = "0x1B1DAD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D20")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D24")]
		public UnitySliceScaleProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D21")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E8A0", Offset = "0x1B1DAA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D1F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E8D0", Offset = "0x1B1DAD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D20")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E810", Offset = "0x1B1DA10", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D22")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E860", Offset = "0x1B1DA60", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D23")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C3")]
	private class UnitySliceTopProperty : ResolvedIntProperty
	{

		[Token(Token = "0x17000832")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D27")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000830")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1E990", Offset = "0x1B1DB90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D25")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000831")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1E9C0", Offset = "0x1B1DBC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D26")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B126C0", Offset = "0x1B118C0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D2A")]
		public UnitySliceTopProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D27")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1E990", Offset = "0x1B1DB90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D25")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1E9C0", Offset = "0x1B1DBC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D26")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E900", Offset = "0x1B1DB00", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D28")]
		public virtual int GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1E950", Offset = "0x1B1DB50", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D29")]
		public virtual void SetValue(ref ResolvedStyleAccess container, int value) { }

	}

	[Token(Token = "0x20003C4")]
	private class UnitySliceTypeProperty : ResolvedEnumProperty<SliceType>
	{

		[Token(Token = "0x17000835")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D2D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000833")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1EAC0", Offset = "0x1B1DCC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D2B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000834")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1EAF0", Offset = "0x1B1DCF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D2C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1EA80", Offset = "0x1B1DC80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D30")]
		public UnitySliceTypeProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D2D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1EAC0", Offset = "0x1B1DCC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D2B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1EAF0", Offset = "0x1B1DCF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D2C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1E9F0", Offset = "0x1B1DBF0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D2E")]
		public virtual SliceType GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1EA40", Offset = "0x1B1DC40", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D2F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, SliceType value) { }

	}

	[Token(Token = "0x20003C5")]
	private class UnityTextAlignProperty : ResolvedEnumProperty<TextAnchor>
	{

		[Token(Token = "0x17000838")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D33")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000836")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1EBF0", Offset = "0x1B1DDF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D31")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000837")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1EC20", Offset = "0x1B1DE20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D32")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1EBB0", Offset = "0x1B1DDB0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D36")]
		public UnityTextAlignProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D33")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1EBF0", Offset = "0x1B1DDF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D31")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1EC20", Offset = "0x1B1DE20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D32")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1EB20", Offset = "0x1B1DD20", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D34")]
		public virtual TextAnchor GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1EB70", Offset = "0x1B1DD70", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D35")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextAnchor value) { }

	}

	[Token(Token = "0x20003C6")]
	private class UnityTextGeneratorProperty : ResolvedEnumProperty<TextGeneratorType>
	{

		[Token(Token = "0x1700083B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D39")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000839")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1ED20", Offset = "0x1B1DF20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D37")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700083A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1ED50", Offset = "0x1B1DF50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D38")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1ECE0", Offset = "0x1B1DEE0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D3C")]
		public UnityTextGeneratorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D39")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1ED20", Offset = "0x1B1DF20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D37")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1ED50", Offset = "0x1B1DF50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D38")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1EC50", Offset = "0x1B1DE50", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D3A")]
		public virtual TextGeneratorType GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1ECA0", Offset = "0x1B1DEA0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D3B")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextGeneratorType value) { }

	}

	[Token(Token = "0x20003C7")]
	private class UnityTextOutlineColorProperty : ResolvedColorProperty
	{

		[Token(Token = "0x1700083E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D3F")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700083C")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1EE90", Offset = "0x1B1E090", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D3D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700083D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1EEC0", Offset = "0x1B1E0C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D3E")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B07960", Offset = "0x1B06B60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D42")]
		public UnityTextOutlineColorProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D3F")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1EE90", Offset = "0x1B1E090", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D3D")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1EEC0", Offset = "0x1B1E0C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D3E")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1ED80", Offset = "0x1B1DF80", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001D40")]
		public virtual Color GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1EE50", Offset = "0x1B1E050", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D41")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Color value) { }

	}

	[Token(Token = "0x20003C8")]
	private class UnityTextOutlineWidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000841")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D45")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700083F")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1EF80", Offset = "0x1B1E180", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D43")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000840")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1EFB0", Offset = "0x1B1E1B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D44")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D48")]
		public UnityTextOutlineWidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D45")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1EF80", Offset = "0x1B1E180", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D43")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1EFB0", Offset = "0x1B1E1B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D44")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1EEF0", Offset = "0x1B1E0F0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D46")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1EF40", Offset = "0x1B1E140", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D47")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003C9")]
	private class UnityTextOverflowPositionProperty : ResolvedEnumProperty<TextOverflowPosition>
	{

		[Token(Token = "0x17000844")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D4B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000842")]
		public virtual string Name
		{
			[Address(RVA = "0x1B1F0B0", Offset = "0x1B1E2B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D49")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000843")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B1F0E0", Offset = "0x1B1E2E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D4A")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B1F070", Offset = "0x1B1E270", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D4E")]
		public UnityTextOverflowPositionProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D4B")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B1F0B0", Offset = "0x1B1E2B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D49")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B1F0E0", Offset = "0x1B1E2E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D4A")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B1EFE0", Offset = "0x1B1E1E0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D4C")]
		public virtual TextOverflowPosition GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B1F030", Offset = "0x1B1E230", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D4D")]
		public virtual void SetValue(ref ResolvedStyleAccess container, TextOverflowPosition value) { }

	}

	[Token(Token = "0x20003CA")]
	private class VisibilityProperty : ResolvedEnumProperty<Visibility>
	{

		[Token(Token = "0x17000847")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D51")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000845")]
		public virtual string Name
		{
			[Address(RVA = "0x1B21730", Offset = "0x1B20930", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D4F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000846")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B21760", Offset = "0x1B20960", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D50")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B216F0", Offset = "0x1B208F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D54")]
		public VisibilityProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D51")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B21730", Offset = "0x1B20930", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D4F")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B21760", Offset = "0x1B20960", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D50")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B21660", Offset = "0x1B20860", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D52")]
		public virtual Visibility GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B216B0", Offset = "0x1B208B0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D53")]
		public virtual void SetValue(ref ResolvedStyleAccess container, Visibility value) { }

	}

	[Token(Token = "0x20003CB")]
	private class WhiteSpaceProperty : ResolvedEnumProperty<WhiteSpace>
	{

		[Token(Token = "0x1700084A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D57")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000848")]
		public virtual string Name
		{
			[Address(RVA = "0x1B231B0", Offset = "0x1B223B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D55")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000849")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B231E0", Offset = "0x1B223E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D56")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B23170", Offset = "0x1B22370", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001D5A")]
		public WhiteSpaceProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D57")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B231B0", Offset = "0x1B223B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D55")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B231E0", Offset = "0x1B223E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D56")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B230E0", Offset = "0x1B222E0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D58")]
		public virtual WhiteSpace GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B23130", Offset = "0x1B22330", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D59")]
		public virtual void SetValue(ref ResolvedStyleAccess container, WhiteSpace value) { }

	}

	[Token(Token = "0x20003CC")]
	private class WidthProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x1700084D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D5D")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700084B")]
		public virtual string Name
		{
			[Address(RVA = "0x1B232A0", Offset = "0x1B224A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D5B")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700084C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B232D0", Offset = "0x1B224D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D5C")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D60")]
		public WidthProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D5D")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B232A0", Offset = "0x1B224A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D5B")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B232D0", Offset = "0x1B224D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D5C")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B23210", Offset = "0x1B22410", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D5E")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B23260", Offset = "0x1B22460", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D5F")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[Token(Token = "0x20003CD")]
	private class WordSpacingProperty : ResolvedFloatProperty
	{

		[Token(Token = "0x17000850")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001D63")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700084E")]
		public virtual string Name
		{
			[Address(RVA = "0x1B23390", Offset = "0x1B22590", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D61")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700084F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1B233C0", Offset = "0x1B225C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001D62")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1B08BD0", Offset = "0x1B07DD0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D66")]
		public WordSpacingProperty() { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001D63")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1B23390", Offset = "0x1B22590", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D61")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1B233C0", Offset = "0x1B225C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001D62")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1B23300", Offset = "0x1B22500", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001D64")]
		public virtual float GetValue(ref ResolvedStyleAccess container) { }

		[Address(RVA = "0x1B23350", Offset = "0x1B22550", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001D65")]
		public virtual void SetValue(ref ResolvedStyleAccess container, float value) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CD2")]
	private readonly List<IProperty`1<ResolvedStyleAccess>> m_PropertiesList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CD3")]
	private readonly Dictionary<String, IProperty`1<ResolvedStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[Address(RVA = "0x1B128B0", Offset = "0x1B11AB0", Length = "0x1DF1")]
	[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.Color>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.Scale>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.StyleFloat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Int32Enum>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResolvedStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.ResolvedStyleAccessPropertyBag+ResolvedStyleProperty`1<UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[Token(Token = "0x6001B82")]
	public ResolvedStyleAccessPropertyBag() { }

	[Address(RVA = "0x756A30", Offset = "0x755C30", Length = "0x17B")]
	[CalledBy(Type = typeof(ResolvedStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B83")]
	private void AddProperty(ResolvedStyleProperty<TValue> property) { }

	[Address(RVA = "0x1B127E0", Offset = "0x1B119E0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001B84")]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties() { }

	[Address(RVA = "0x1B12780", Offset = "0x1B11980", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001B85")]
	public virtual PropertyCollection<ResolvedStyleAccess> GetProperties(ref ResolvedStyleAccess container) { }

	[Address(RVA = "0x1B12840", Offset = "0x1B11A40", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B86")]
	public override bool TryGetProperty(ref ResolvedStyleAccess container, string name, out IProperty<ResolvedStyleAccess>& property) { }

}

