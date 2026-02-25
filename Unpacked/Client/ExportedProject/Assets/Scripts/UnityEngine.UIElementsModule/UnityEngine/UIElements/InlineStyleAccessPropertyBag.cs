namespace UnityEngine.UIElements;

[Token(Token = "0x20002FE")]
internal class InlineStyleAccessPropertyBag : PropertyBag<InlineStyleAccess>, INamedProperties<InlineStyleAccess>
{
	[Token(Token = "0x20002FF")]
	private class AlignContentProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004AB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001628")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004A9")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD26E0", Offset = "0x1AD18E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001626")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004AA")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD2710", Offset = "0x1AD1910", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001627")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD26A0", Offset = "0x1AD18A0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600162B")]
		public AlignContentProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001628")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD26E0", Offset = "0x1AD18E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001626")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD2710", Offset = "0x1AD1910", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001627")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD25F0", Offset = "0x1AD17F0", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001629")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD2640", Offset = "0x1AD1840", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600162A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x2000300")]
	private class AlignItemsProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004AE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600162E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004AC")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD2830", Offset = "0x1AD1A30", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600162C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004AD")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD2860", Offset = "0x1AD1A60", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600162D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD27F0", Offset = "0x1AD19F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001631")]
		public AlignItemsProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600162E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD2830", Offset = "0x1AD1A30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600162C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD2860", Offset = "0x1AD1A60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600162D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD2740", Offset = "0x1AD1940", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600162F")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD2790", Offset = "0x1AD1990", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001630")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x2000301")]
	private class AlignSelfProperty : InlineStyleEnumProperty<Align>
	{

		[Token(Token = "0x170004B1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001634")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004AF")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD2980", Offset = "0x1AD1B80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001632")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004B0")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD29B0", Offset = "0x1AD1BB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001633")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2940", Offset = "0x1AD1B40", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001637")]
		public AlignSelfProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001634")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD2980", Offset = "0x1AD1B80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001632")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD29B0", Offset = "0x1AD1BB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001633")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD2890", Offset = "0x1AD1A90", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001635")]
		public virtual StyleEnum<Align> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD28E0", Offset = "0x1AD1AE0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001636")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Align> value) { }

	}

	[Token(Token = "0x2000302")]
	private class BackgroundColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004B4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600163A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004B2")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD2F90", Offset = "0x1AD2190", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001638")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004B3")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD2FC0", Offset = "0x1AD21C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001639")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600163D")]
		public BackgroundColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD2F90", Offset = "0x1AD2190", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001638")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD2FC0", Offset = "0x1AD21C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001639")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD2DC0", Offset = "0x1AD1FC0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600163B")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD2EA0", Offset = "0x1AD20A0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600163C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000303")]
	private class BackgroundImageProperty : InlineStyleBackgroundProperty
	{

		[Token(Token = "0x170004B7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001640")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004B5")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD31E0", Offset = "0x1AD23E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600163E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004B6")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD3210", Offset = "0x1AD2410", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600163F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD31D0", Offset = "0x1AD23D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001643")]
		public BackgroundImageProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001640")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD31E0", Offset = "0x1AD23E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600163E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD3210", Offset = "0x1AD2410", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600163F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD2FF0", Offset = "0x1AD21F0", Length = "0xE1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001641")]
		public virtual StyleBackground GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD30E0", Offset = "0x1AD22E0", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001642")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackground value) { }

	}

	[Token(Token = "0x2000304")]
	private class BackgroundPositionXProperty : InlineStyleBackgroundPositionProperty
	{

		[Token(Token = "0x170004BA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001646")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004B8")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD33F0", Offset = "0x1AD25F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001644")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004B9")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD3420", Offset = "0x1AD2620", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001645")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD33E0", Offset = "0x1AD25E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundPositionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001649")]
		public BackgroundPositionXProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001646")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD33F0", Offset = "0x1AD25F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001644")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD3420", Offset = "0x1AD2620", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001645")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD3240", Offset = "0x1AD2440", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001647")]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD3310", Offset = "0x1AD2510", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001648")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	[Token(Token = "0x2000305")]
	private class BackgroundPositionYProperty : InlineStyleBackgroundPositionProperty
	{

		[Token(Token = "0x170004BD")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600164C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004BB")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD35F0", Offset = "0x1AD27F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600164A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004BC")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD3620", Offset = "0x1AD2820", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600164B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD33E0", Offset = "0x1AD25E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundPositionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600164F")]
		public BackgroundPositionYProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600164C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD35F0", Offset = "0x1AD27F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600164A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD3620", Offset = "0x1AD2820", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600164B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD3450", Offset = "0x1AD2650", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600164D")]
		public virtual StyleBackgroundPosition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD3520", Offset = "0x1AD2720", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600164E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundPosition value) { }

	}

	[Token(Token = "0x2000306")]
	private class BackgroundRepeatProperty : InlineStyleBackgroundRepeatProperty
	{

		[Token(Token = "0x170004C0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001652")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004BE")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD3820", Offset = "0x1AD2A20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001650")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004BF")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD3850", Offset = "0x1AD2A50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001651")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD3810", Offset = "0x1AD2A10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundRepeatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001655")]
		public BackgroundRepeatProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001652")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD3820", Offset = "0x1AD2A20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001650")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD3850", Offset = "0x1AD2A50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001651")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD3650", Offset = "0x1AD2850", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001653")]
		public virtual StyleBackgroundRepeat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD3730", Offset = "0x1AD2930", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001654")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundRepeat value) { }

	}

	[Token(Token = "0x2000307")]
	private class BackgroundSizeProperty : InlineStyleBackgroundSizeProperty
	{

		[Token(Token = "0x170004C3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001658")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004C1")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD39E0", Offset = "0x1AD2BE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001656")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004C2")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD3A10", Offset = "0x1AD2C10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001657")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD39D0", Offset = "0x1AD2BD0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleBackgroundSizeProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600165B")]
		public BackgroundSizeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001658")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD39E0", Offset = "0x1AD2BE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001656")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD3A10", Offset = "0x1AD2C10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001657")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD3880", Offset = "0x1AD2A80", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001659")]
		public virtual StyleBackgroundSize GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD38F0", Offset = "0x1AD2AF0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600165A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleBackgroundSize value) { }

	}

	[Token(Token = "0x2000308")]
	private class BorderBottomColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004C6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600165E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004C4")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD4D80", Offset = "0x1AD3F80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600165C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004C5")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD4DB0", Offset = "0x1AD3FB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600165D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001661")]
		public BorderBottomColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600165E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD4D80", Offset = "0x1AD3F80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600165C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD4DB0", Offset = "0x1AD3FB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600165D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD4BC0", Offset = "0x1AD3DC0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600165F")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD4CA0", Offset = "0x1AD3EA0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001660")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000309")]
	private class BorderBottomLeftRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004C9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001664")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004C7")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD4FB0", Offset = "0x1AD41B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001662")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004C8")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD4FE0", Offset = "0x1AD41E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001663")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001667")]
		public BorderBottomLeftRadiusProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001664")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD4FB0", Offset = "0x1AD41B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001662")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD4FE0", Offset = "0x1AD41E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001663")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD4DE0", Offset = "0x1AD3FE0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001665")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD4EC0", Offset = "0x1AD40C0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001666")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200030A")]
	private class BorderBottomRightRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004CC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600166A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004CA")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD51D0", Offset = "0x1AD43D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001668")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004CB")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5200", Offset = "0x1AD4400", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001669")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600166D")]
		public BorderBottomRightRadiusProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600166A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD51D0", Offset = "0x1AD43D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001668")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5200", Offset = "0x1AD4400", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001669")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5010", Offset = "0x1AD4210", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600166B")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD50F0", Offset = "0x1AD42F0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600166C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200030B")]
	private class BorderBottomWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004CF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001670")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004CD")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD52F0", Offset = "0x1AD44F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600166E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004CE")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5320", Offset = "0x1AD4520", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600166F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001673")]
		public BorderBottomWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001670")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD52F0", Offset = "0x1AD44F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600166E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5320", Offset = "0x1AD4520", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600166F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5230", Offset = "0x1AD4430", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001671")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5280", Offset = "0x1AD4480", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001672")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200030C")]
	private class BorderLeftColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004D2")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001676")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D0")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5510", Offset = "0x1AD4710", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001674")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D1")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5540", Offset = "0x1AD4740", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001675")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001679")]
		public BorderLeftColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001676")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5510", Offset = "0x1AD4710", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001674")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5540", Offset = "0x1AD4740", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001675")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5350", Offset = "0x1AD4550", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001677")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5430", Offset = "0x1AD4630", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001678")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200030D")]
	private class BorderLeftWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004D5")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600167C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D3")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5620", Offset = "0x1AD4820", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600167A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D4")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5650", Offset = "0x1AD4850", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600167B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600167F")]
		public BorderLeftWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600167C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5620", Offset = "0x1AD4820", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600167A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5650", Offset = "0x1AD4850", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600167B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5570", Offset = "0x1AD4770", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600167D")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD55C0", Offset = "0x1AD47C0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600167E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200030E")]
	private class BorderRightColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004D8")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001682")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D6")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5840", Offset = "0x1AD4A40", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001680")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004D7")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5870", Offset = "0x1AD4A70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001681")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001685")]
		public BorderRightColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001682")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5840", Offset = "0x1AD4A40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001680")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5870", Offset = "0x1AD4A70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001681")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5680", Offset = "0x1AD4880", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001683")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5760", Offset = "0x1AD4960", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001684")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200030F")]
	private class BorderRightWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004DB")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001688")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004D9")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5950", Offset = "0x1AD4B50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001686")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004DA")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5980", Offset = "0x1AD4B80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001687")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600168B")]
		public BorderRightWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001688")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5950", Offset = "0x1AD4B50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001686")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5980", Offset = "0x1AD4B80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001687")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD58A0", Offset = "0x1AD4AA0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001689")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD58F0", Offset = "0x1AD4AF0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600168A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000310")]
	private class BorderTopColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004DE")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600168E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004DC")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5B70", Offset = "0x1AD4D70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600168C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004DD")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5BA0", Offset = "0x1AD4DA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600168D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001691")]
		public BorderTopColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600168E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5B70", Offset = "0x1AD4D70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600168C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5BA0", Offset = "0x1AD4DA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600168D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD59B0", Offset = "0x1AD4BB0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600168F")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5A90", Offset = "0x1AD4C90", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001690")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000311")]
	private class BorderTopLeftRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004E1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001694")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004DF")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5D90", Offset = "0x1AD4F90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001692")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E0")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5DC0", Offset = "0x1AD4FC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001693")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001697")]
		public BorderTopLeftRadiusProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001694")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5D90", Offset = "0x1AD4F90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001692")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5DC0", Offset = "0x1AD4FC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001693")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5BD0", Offset = "0x1AD4DD0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001695")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5CB0", Offset = "0x1AD4EB0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001696")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000312")]
	private class BorderTopRightRadiusProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004E4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600169A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E2")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD5FB0", Offset = "0x1AD51B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001698")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E3")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD5FE0", Offset = "0x1AD51E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001699")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600169D")]
		public BorderTopRightRadiusProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600169A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD5FB0", Offset = "0x1AD51B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001698")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD5FE0", Offset = "0x1AD51E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001699")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD5DF0", Offset = "0x1AD4FF0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600169B")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD5ED0", Offset = "0x1AD50D0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600169C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000313")]
	private class BorderTopWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004E7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016A0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E5")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD60C0", Offset = "0x1AD52C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600169E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E6")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD60F0", Offset = "0x1AD52F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600169F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A3")]
		public BorderTopWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD60C0", Offset = "0x1AD52C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600169E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD60F0", Offset = "0x1AD52F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600169F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD6010", Offset = "0x1AD5210", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016A1")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD6060", Offset = "0x1AD5260", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016A2")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000314")]
	private class BottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004EA")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016A6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004E8")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD62E0", Offset = "0x1AD54E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016A4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004E9")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD6310", Offset = "0x1AD5510", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016A5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A9")]
		public BottomProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016A6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD62E0", Offset = "0x1AD54E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016A4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD6310", Offset = "0x1AD5510", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016A5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD6120", Offset = "0x1AD5320", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016A7")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD6200", Offset = "0x1AD5400", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016A8")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000315")]
	private class ColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x170004ED")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016AC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004EB")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD6500", Offset = "0x1AD5700", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016AA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004EC")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD6530", Offset = "0x1AD5730", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016AB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AF")]
		public ColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD6500", Offset = "0x1AD5700", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016AA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD6530", Offset = "0x1AD5730", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016AB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD6340", Offset = "0x1AD5540", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016AD")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD6420", Offset = "0x1AD5620", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016AE")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x2000316")]
	private class CursorProperty : InlineStyleCursorProperty
	{

		[Token(Token = "0x170004F0")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016B2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004EE")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD8A80", Offset = "0x1AD7C80", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016B0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004EF")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD8AB0", Offset = "0x1AD7CB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016B1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD8A70", Offset = "0x1AD7C70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleCursorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60016B5")]
		public CursorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD8A80", Offset = "0x1AD7C80", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016B0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD8AB0", Offset = "0x1AD7CB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016B1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD88B0", Offset = "0x1AD7AB0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B3")]
		public virtual StyleCursor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD8990", Offset = "0x1AD7B90", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B4")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleCursor value) { }

	}

	[Token(Token = "0x2000317")]
	private class DisplayProperty : InlineStyleEnumProperty<DisplayStyle>
	{

		[Token(Token = "0x170004F3")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016B8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F1")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD8CA0", Offset = "0x1AD7EA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016B6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F2")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD8CD0", Offset = "0x1AD7ED0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016B7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD8C60", Offset = "0x1AD7E60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60016BB")]
		public DisplayProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD8CA0", Offset = "0x1AD7EA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016B6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD8CD0", Offset = "0x1AD7ED0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016B7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD8AE0", Offset = "0x1AD7CE0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60016B9")]
		public virtual StyleEnum<DisplayStyle> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD8BA0", Offset = "0x1AD7DA0", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BA")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<DisplayStyle> value) { }

	}

	[Token(Token = "0x2000318")]
	private class FlexBasisProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170004F6")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016BE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F4")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD9CD0", Offset = "0x1AD8ED0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016BC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F5")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD9D00", Offset = "0x1AD8F00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016BD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C1")]
		public FlexBasisProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016BE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD9CD0", Offset = "0x1AD8ED0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016BC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD9D00", Offset = "0x1AD8F00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016BD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD9B10", Offset = "0x1AD8D10", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BF")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD9BF0", Offset = "0x1AD8DF0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016C0")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000319")]
	private class FlexDirectionProperty : InlineStyleEnumProperty<FlexDirection>
	{

		[Token(Token = "0x170004F9")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016C4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004F7")]
		public virtual string Name
		{
			[Address(RVA = "0x1AD9EF0", Offset = "0x1AD90F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016C2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004F8")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AD9F20", Offset = "0x1AD9120", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016C3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD9EB0", Offset = "0x1AD90B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60016C7")]
		public FlexDirectionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AD9EF0", Offset = "0x1AD90F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016C2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AD9F20", Offset = "0x1AD9120", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016C3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD9D30", Offset = "0x1AD8F30", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60016C5")]
		public virtual StyleEnum<FlexDirection> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD9DF0", Offset = "0x1AD8FF0", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016C6")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FlexDirection> value) { }

	}

	[Token(Token = "0x200031A")]
	private class FlexGrowProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004FC")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016CA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004FA")]
		public virtual string Name
		{
			[Address(RVA = "0x1ADA000", Offset = "0x1AD9200", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016C8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004FB")]
		public virtual string ussName
		{
			[Address(RVA = "0x1ADA030", Offset = "0x1AD9230", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016C9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CD")]
		public FlexGrowProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016CA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1ADA000", Offset = "0x1AD9200", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016C8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1ADA030", Offset = "0x1AD9230", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016C9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AD9F50", Offset = "0x1AD9150", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016CB")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AD9FA0", Offset = "0x1AD91A0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016CC")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200031B")]
	private class FlexShrinkProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x170004FF")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016D0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170004FD")]
		public virtual string Name
		{
			[Address(RVA = "0x1ADA110", Offset = "0x1AD9310", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016CE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170004FE")]
		public virtual string ussName
		{
			[Address(RVA = "0x1ADA140", Offset = "0x1AD9340", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016CF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016D3")]
		public FlexShrinkProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016D0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1ADA110", Offset = "0x1AD9310", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016CE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1ADA140", Offset = "0x1AD9340", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016CF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1ADA060", Offset = "0x1AD9260", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016D1")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1ADA0B0", Offset = "0x1AD92B0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016D2")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200031C")]
	private class FlexWrapProperty : InlineStyleEnumProperty<Wrap>
	{

		[Token(Token = "0x17000502")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016D6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000500")]
		public virtual string Name
		{
			[Address(RVA = "0x1ADA330", Offset = "0x1AD9530", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016D4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000501")]
		public virtual string ussName
		{
			[Address(RVA = "0x1ADA360", Offset = "0x1AD9560", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016D5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1ADA2F0", Offset = "0x1AD94F0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60016D9")]
		public FlexWrapProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016D6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1ADA330", Offset = "0x1AD9530", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016D4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1ADA360", Offset = "0x1AD9560", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016D5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1ADA170", Offset = "0x1AD9370", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60016D7")]
		public virtual StyleEnum<Wrap> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1ADA230", Offset = "0x1AD9430", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016D8")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Wrap> value) { }

	}

	[Token(Token = "0x200031D")]
	private class FontSizeProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000505")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016DC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000503")]
		public virtual string Name
		{
			[Address(RVA = "0x1ADADA0", Offset = "0x1AD9FA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016DA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000504")]
		public virtual string ussName
		{
			[Address(RVA = "0x1ADADD0", Offset = "0x1AD9FD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016DB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016DF")]
		public FontSizeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016DC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1ADADA0", Offset = "0x1AD9FA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016DA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1ADADD0", Offset = "0x1AD9FD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016DB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1ADABE0", Offset = "0x1AD9DE0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016DD")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1ADACC0", Offset = "0x1AD9EC0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016DE")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200031E")]
	private class HeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000508")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000506")]
		public virtual string Name
		{
			[Address(RVA = "0x1ADAFC0", Offset = "0x1ADA1C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016E0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000507")]
		public virtual string ussName
		{
			[Address(RVA = "0x1ADAFF0", Offset = "0x1ADA1F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016E1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E5")]
		public HeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1ADAFC0", Offset = "0x1ADA1C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016E0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1ADAFF0", Offset = "0x1ADA1F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016E1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1ADAE00", Offset = "0x1ADA000", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016E3")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1ADAEE0", Offset = "0x1ADA0E0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016E4")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200036B")]
	private abstract class InlineStyleBackgroundPositionProperty : InlineStyleProperty<StyleBackgroundPosition, BackgroundPosition>
	{

		[Address(RVA = "0x1AEF370", Offset = "0x1AEE570", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundPositionXProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundPositionYProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundPosition, BackgroundPosition>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001859")]
		protected InlineStyleBackgroundPositionProperty() { }

	}

	[Token(Token = "0x2000359")]
	private abstract class InlineStyleBackgroundProperty : InlineStyleProperty<StyleBackground, Background>
	{
		[CompilerGenerated]
		[Token(Token = "0x200035A")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C35")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C36")]
			public static TypeConverter<Texture2D, StyleBackground> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C37")]
			public static TypeConverter<Sprite, StyleBackground> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C38")]
			public static TypeConverter<VectorImage, StyleBackground> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C39")]
			public static TypeConverter<StyleBackground, Texture2D> <>9__0_3; //Field offset: 0x20
			[Token(Token = "0x4000C3A")]
			public static TypeConverter<StyleBackground, Sprite> <>9__0_4; //Field offset: 0x28
			[Token(Token = "0x4000C3B")]
			public static TypeConverter<StyleBackground, RenderTexture> <>9__0_5; //Field offset: 0x30
			[Token(Token = "0x4000C3C")]
			public static TypeConverter<StyleBackground, VectorImage> <>9__0_6; //Field offset: 0x38

			[Address(RVA = "0x1AF1F10", Offset = "0x1AF1110", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001833")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001834")]
			public <>c() { }

			[Address(RVA = "0x1AF1B70", Offset = "0x1AF0D70", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001835")]
			internal StyleBackground <.ctor>b__0_0(ref Texture2D v) { }

			[Address(RVA = "0x1AF1C20", Offset = "0x1AF0E20", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001836")]
			internal StyleBackground <.ctor>b__0_1(ref Sprite v) { }

			[Address(RVA = "0x1AF1CB0", Offset = "0x1AF0EB0", Length = "0x2D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VectorImage)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001837")]
			internal StyleBackground <.ctor>b__0_2(ref VectorImage v) { }

			[Address(RVA = "0x1AF1D40", Offset = "0x1AF0F40", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001838")]
			internal Texture2D <.ctor>b__0_3(ref StyleBackground sv) { }

			[Address(RVA = "0x1AF1DE0", Offset = "0x1AF0FE0", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001839")]
			internal Sprite <.ctor>b__0_4(ref StyleBackground sv) { }

			[Address(RVA = "0x1AF1E20", Offset = "0x1AF1020", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600183A")]
			internal RenderTexture <.ctor>b__0_5(ref StyleBackground sv) { }

			[Address(RVA = "0x1AF1E60", Offset = "0x1AF1060", Length = "0x40")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleBackground), Member = "get_value", ReturnType = typeof(Background))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600183B")]
			internal VectorImage <.ctor>b__0_6(ref StyleBackground sv) { }

		}


		[Address(RVA = "0x1AEF3B0", Offset = "0x1AEE5B0", Length = "0x68C")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundImageProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackground, Background>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.TypeConverter`2<System.Object, UnityEngine.UIElements.StyleBackground>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[Token(Token = "0x6001832")]
		protected InlineStyleBackgroundProperty() { }

	}

	[Token(Token = "0x200036C")]
	private abstract class InlineStyleBackgroundRepeatProperty : InlineStyleProperty<StyleBackgroundRepeat, BackgroundRepeat>
	{

		[Address(RVA = "0x1AEFA40", Offset = "0x1AEEC40", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundRepeatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundRepeat, BackgroundRepeat>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600185A")]
		protected InlineStyleBackgroundRepeatProperty() { }

	}

	[Token(Token = "0x200036D")]
	private abstract class InlineStyleBackgroundSizeProperty : InlineStyleProperty<StyleBackgroundSize, BackgroundSize>
	{

		[Address(RVA = "0x1AEFA80", Offset = "0x1AEEC80", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundSizeProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleBackgroundSize, BackgroundSize>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600185B")]
		protected InlineStyleBackgroundSizeProperty() { }

	}

	[Token(Token = "0x2000357")]
	private abstract class InlineStyleColorProperty : InlineStyleProperty<StyleColor, Color>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000358")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C32")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C33")]
			public static TypeConverter<Color32, StyleColor> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C34")]
			public static TypeConverter<StyleColor, Color32> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x1AF1EA0", Offset = "0x1AF10A0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600182E")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600182F")]
			public <>c() { }

			[Address(RVA = "0x1AF1AC0", Offset = "0x1AF0CC0", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001830")]
			internal StyleColor <.ctor>b__0_0(ref Color32 v) { }

			[Address(RVA = "0x1AF1C80", Offset = "0x1AF0E80", Length = "0x2A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleColor), Member = "get_value", ReturnType = typeof(Color))]
			[Calls(Type = typeof(Color32), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(Color32))]
			[Token(Token = "0x6001831")]
			internal Color32 <.ctor>b__0_1(ref StyleColor sv) { }

		}


		[Address(RVA = "0x1AEFAC0", Offset = "0x1AEECC0", Length = "0x21E")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityTextOutlineColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BackgroundColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderBottomColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderLeftColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderRightColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderTopColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+ColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityBackgroundImageTintColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleColor, Color>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600182D")]
		protected InlineStyleColorProperty() { }

	}

	[Token(Token = "0x2000366")]
	private abstract class InlineStyleCursorProperty : InlineStyleProperty<StyleCursor, Cursor>
	{

		[Address(RVA = "0x1AEFCE0", Offset = "0x1AEEEE0", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+CursorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleCursor, Cursor>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001854")]
		protected InlineStyleCursorProperty() { }

	}

	[Token(Token = "0x2000356")]
	private abstract class InlineStyleEnumProperty : InlineStyleProperty<StyleEnum`1<TValue>, TValue>
	{

		[Address(RVA = "0xC8FBF0", Offset = "0xC8EDF0", Length = "0x13")]
		[CallerCount(Count = 38)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600182C")]
		protected InlineStyleEnumProperty`1() { }

	}

	[Token(Token = "0x200035D")]
	private abstract class InlineStyleFloatProperty : InlineStyleProperty<StyleFloat, Single>
	{
		[CompilerGenerated]
		[Token(Token = "0x200035E")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C42")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C43")]
			public static TypeConverter<Int32, StyleFloat> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C44")]
			public static TypeConverter<StyleFloat, Int32> <>9__0_1; //Field offset: 0x10

			[Address(RVA = "0x1AF2060", Offset = "0x1AF1260", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001844")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001845")]
			public <>c() { }

			[Address(RVA = "0x1AF1A60", Offset = "0x1AF0C60", Length = "0x2B")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001846")]
			internal StyleFloat <.ctor>b__0_0(ref int v) { }

			[Address(RVA = "0x1AF1BD0", Offset = "0x1AF0DD0", Length = "0x17")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFloat), Member = "get_value", ReturnType = typeof(float))]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001847")]
			internal int <.ctor>b__0_1(ref StyleFloat sv) { }

		}


		[Address(RVA = "0x1AEFD20", Offset = "0x1AEEF20", Length = "0x21E")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityTextOutlineWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+OpacityProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+FlexShrinkProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+FlexGrowProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceScaleProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderRightWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderLeftWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderBottomWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+BorderTopWidthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFloat, Single>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001843")]
		protected InlineStyleFloatProperty() { }

	}

	[Token(Token = "0x2000361")]
	private abstract class InlineStyleFontDefinitionProperty : InlineStyleProperty<StyleFontDefinition, FontDefinition>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000362")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C45")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C46")]
			public static TypeConverter<Font, StyleFontDefinition> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C47")]
			public static TypeConverter<FontAsset, StyleFontDefinition> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C48")]
			public static TypeConverter<StyleFontDefinition, Font> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C49")]
			public static TypeConverter<StyleFontDefinition, FontAsset> <>9__0_3; //Field offset: 0x20

			[Address(RVA = "0x1AF1F80", Offset = "0x1AF1180", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600184B")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600184C")]
			public <>c() { }

			[Address(RVA = "0x1AF1A90", Offset = "0x1AF0C90", Length = "0x29")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
			[Token(Token = "0x600184D")]
			internal StyleFontDefinition <.ctor>b__0_0(ref Font v) { }

			[Address(RVA = "0x1AF1BF0", Offset = "0x1AF0DF0", Length = "0x29")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
			[Token(Token = "0x600184E")]
			internal StyleFontDefinition <.ctor>b__0_1(ref FontAsset v) { }

			[Address(RVA = "0x1AF1CE0", Offset = "0x1AF0EE0", Length = "0x32")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600184F")]
			internal Font <.ctor>b__0_2(ref StyleFontDefinition sv) { }

			[Address(RVA = "0x1AF1D80", Offset = "0x1AF0F80", Length = "0x32")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleFontDefinition), Member = "get_value", ReturnType = typeof(FontDefinition))]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6001850")]
			internal FontAsset <.ctor>b__0_3(ref StyleFontDefinition sv) { }

		}


		[Address(RVA = "0x1AEFF40", Offset = "0x1AEF140", Length = "0x3E6")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityFontDefinitionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFontDefinition, FontDefinition>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Unity.Properties.TypeConverter`2<System.Object, UnityEngine.UIElements.StyleFontDefinition>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600184A")]
		protected InlineStyleFontDefinitionProperty() { }

	}

	[Token(Token = "0x2000360")]
	private abstract class InlineStyleFontProperty : InlineStyleProperty<StyleFont, Font>
	{

		[Address(RVA = "0x1AF0330", Offset = "0x1AEF530", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityFontProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleFont, Object>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001849")]
		protected InlineStyleFontProperty() { }

	}

	[Token(Token = "0x2000363")]
	private abstract class InlineStyleIntProperty : InlineStyleProperty<StyleInt, Int32>
	{

		[Address(RVA = "0x1AF0370", Offset = "0x1AEF570", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceBottomProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceLeftProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceRightProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnitySliceTopProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleInt, Int32>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001851")]
		protected InlineStyleIntProperty() { }

	}

	[Token(Token = "0x200035B")]
	private abstract class InlineStyleLengthProperty : InlineStyleProperty<StyleLength, Length>
	{
		[CompilerGenerated]
		[Token(Token = "0x200035C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C3D")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C3E")]
			public static TypeConverter<Single, StyleLength> <>9__0_0; //Field offset: 0x8
			[Token(Token = "0x4000C3F")]
			public static TypeConverter<Int32, StyleLength> <>9__0_1; //Field offset: 0x10
			[Token(Token = "0x4000C40")]
			public static TypeConverter<StyleLength, Single> <>9__0_2; //Field offset: 0x18
			[Token(Token = "0x4000C41")]
			public static TypeConverter<StyleLength, Int32> <>9__0_3; //Field offset: 0x20

			[Address(RVA = "0x1AF1FF0", Offset = "0x1AF11F0", Length = "0x67")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600183D")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600183E")]
			public <>c() { }

			[Address(RVA = "0x1AF1BA0", Offset = "0x1AF0DA0", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[Token(Token = "0x600183F")]
			internal StyleLength <.ctor>b__0_0(ref float v) { }

			[Address(RVA = "0x1AF1C50", Offset = "0x1AF0E50", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
			[Token(Token = "0x6001840")]
			internal StyleLength <.ctor>b__0_1(ref int v) { }

			[Address(RVA = "0x1AF1D20", Offset = "0x1AF0F20", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
			[Token(Token = "0x6001841")]
			internal float <.ctor>b__0_2(ref StyleLength sv) { }

			[Address(RVA = "0x1AF1DC0", Offset = "0x1AF0FC0", Length = "0x1E")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(StyleLength), Member = "get_value", ReturnType = typeof(Length))]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001842")]
			internal int <.ctor>b__0_3(ref StyleLength sv) { }

		}


		[Address(RVA = "0x1AF03B0", Offset = "0x1AEF5B0", Length = "0x3E6")]
		[CallerCount(Count = 54)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleLength, Length>", Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[Token(Token = "0x600183C")]
		protected InlineStyleLengthProperty() { }

	}

	[Token(Token = "0x200035F")]
	private abstract class InlineStyleListProperty : InlineStyleProperty<StyleList`1<T>, List`1<T>>
	{

		[Address(RVA = "0xC8FC30", Offset = "0xC8EE30", Length = "0x13")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+TransitionTimingFunctionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleList`1<EasingFunction>, Object>", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001848")]
		protected InlineStyleListProperty`1() { }

	}

	[Token(Token = "0x2000354")]
	private abstract class InlineStyleProperty : Property<InlineStyleAccess, TStyleValue>
	{
		[CompilerGenerated]
		[Token(Token = "0x2000355")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C2D")]
			public static readonly <>c<TStyleValue, TValue> <>9; //Field offset: 0x0
			[Token(Token = "0x4000C2E")]
			public static TypeConverter<TStyleValue, TValue> <>9__0_0; //Field offset: 0x0
			[Token(Token = "0x4000C2F")]
			public static TypeConverter<TValue, TStyleValue> <>9__0_1; //Field offset: 0x0
			[Token(Token = "0x4000C30")]
			public static TypeConverter<TStyleValue, StyleKeyword> <>9__0_2; //Field offset: 0x0
			[Token(Token = "0x4000C31")]
			public static TypeConverter<StyleKeyword, TStyleValue> <>9__0_3; //Field offset: 0x0

			[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001826")]
			private static <>c() { }

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001827")]
			public <>c() { }

			[Address(RVA = "0x7FA6B0", Offset = "0x7F98B0", Length = "0x17")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001828")]
			internal TValue <.ctor>b__0_0(ref TStyleValue sv) { }

			[Address(RVA = "0x7FAC00", Offset = "0x7F9E00", Length = "0x54")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001829")]
			internal TStyleValue <.ctor>b__0_1(ref TValue v) { }

			[Address(RVA = "0x7FB5B0", Offset = "0x7FA7B0", Length = "0x17")]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600182A")]
			internal StyleKeyword <.ctor>b__0_2(ref TStyleValue sv) { }

			[Address(RVA = "0x7FB610", Offset = "0x7FA810", Length = "0x54")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600182B")]
			internal TStyleValue <.ctor>b__0_3(ref StyleKeyword kw) { }

		}


		[Token(Token = "0x170005A8")]
		public abstract string ussName
		{
			[Token(Token = "0x6001825")]
			 get { } //Length: 0
		}

		[Address(RVA = "0xC90340", Offset = "0xC8F540", Length = "0x6AE")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TypeConverter`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ConverterGroups), Member = "RegisterGlobal", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.TypeConverter`2<TSource, TDestination>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001824")]
		protected InlineStyleProperty`2() { }

		[Token(Token = "0x6001825")]
		public abstract string get_ussName() { }

	}

	[Token(Token = "0x2000364")]
	private abstract class InlineStyleRotateProperty : InlineStyleProperty<StyleRotate, Rotate>
	{

		[Address(RVA = "0x1AF07A0", Offset = "0x1AEF9A0", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+RotateProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleRotate, Rotate>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001852")]
		protected InlineStyleRotateProperty() { }

	}

	[Token(Token = "0x2000365")]
	private abstract class InlineStyleScaleProperty : InlineStyleProperty<StyleScale, Scale>
	{

		[Address(RVA = "0x1AF07E0", Offset = "0x1AEF9E0", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+ScaleProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleScale, Scale>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001853")]
		protected InlineStyleScaleProperty() { }

	}

	[Token(Token = "0x2000368")]
	private abstract class InlineStyleTextAutoSizeProperty : InlineStyleProperty<StyleTextAutoSize, TextAutoSize>
	{

		[Address(RVA = "0x1AF0820", Offset = "0x1AEFA20", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+UnityTextAutoSizeProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTextAutoSize, TextAutoSize>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001856")]
		protected InlineStyleTextAutoSizeProperty() { }

	}

	[Token(Token = "0x2000367")]
	private abstract class InlineStyleTextShadowProperty : InlineStyleProperty<StyleTextShadow, TextShadow>
	{

		[Address(RVA = "0x1AF0860", Offset = "0x1AEFA60", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+TextShadowProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTextShadow, TextShadow>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001855")]
		protected InlineStyleTextShadowProperty() { }

	}

	[Token(Token = "0x2000369")]
	private abstract class InlineStyleTransformOriginProperty : InlineStyleProperty<StyleTransformOrigin, TransformOrigin>
	{

		[Address(RVA = "0x1AF08A0", Offset = "0x1AEFAA0", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+TransformOriginProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTransformOrigin, TransformOrigin>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001857")]
		protected InlineStyleTransformOriginProperty() { }

	}

	[Token(Token = "0x200036A")]
	private abstract class InlineStyleTranslateProperty : InlineStyleProperty<StyleTranslate, Translate>
	{

		[Address(RVA = "0x1AF08E0", Offset = "0x1AEFAE0", Length = "0x39")]
		[CalledBy(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+TranslateProperty", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<StyleTranslate, Translate>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001858")]
		protected InlineStyleTranslateProperty() { }

	}

	[Token(Token = "0x200031F")]
	private class JustifyContentProperty : InlineStyleEnumProperty<Justify>
	{

		[Token(Token = "0x1700050B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016E8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000509")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE69C0", Offset = "0x1AE5BC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016E6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700050A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE69F0", Offset = "0x1AE5BF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016E7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AE6980", Offset = "0x1AE5B80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60016EB")]
		public JustifyContentProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016E8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE69C0", Offset = "0x1AE5BC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016E6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE69F0", Offset = "0x1AE5BF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016E7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE6800", Offset = "0x1AE5A00", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60016E9")]
		public virtual StyleEnum<Justify> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE68C0", Offset = "0x1AE5AC0", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016EA")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Justify> value) { }

	}

	[Token(Token = "0x2000320")]
	private class LeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700050E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016EE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700050C")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE6BE0", Offset = "0x1AE5DE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016EC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700050D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE6C10", Offset = "0x1AE5E10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016ED")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016F1")]
		public LeftProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016EE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE6BE0", Offset = "0x1AE5DE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016EC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE6C10", Offset = "0x1AE5E10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016ED")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE6A20", Offset = "0x1AE5C20", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016EF")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE6B00", Offset = "0x1AE5D00", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016F0")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000321")]
	private class LetterSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000511")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016F4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700050F")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE6E00", Offset = "0x1AE6000", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016F2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000510")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE6E30", Offset = "0x1AE6030", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016F3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016F7")]
		public LetterSpacingProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016F4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE6E00", Offset = "0x1AE6000", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016F2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE6E30", Offset = "0x1AE6030", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016F3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE6C40", Offset = "0x1AE5E40", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016F5")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE6D20", Offset = "0x1AE5F20", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016F6")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000322")]
	private class MarginBottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000514")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016FA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000512")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7020", Offset = "0x1AE6220", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016F8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000513")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7050", Offset = "0x1AE6250", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016F9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60016FD")]
		public MarginBottomProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016FA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7020", Offset = "0x1AE6220", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016F8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7050", Offset = "0x1AE6250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016F9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE6E60", Offset = "0x1AE6060", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016FB")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE6F40", Offset = "0x1AE6140", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016FC")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000323")]
	private class MarginLeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000517")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001700")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000515")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7240", Offset = "0x1AE6440", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016FE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000516")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7270", Offset = "0x1AE6470", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60016FF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001703")]
		public MarginLeftProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001700")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7240", Offset = "0x1AE6440", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016FE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7270", Offset = "0x1AE6470", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60016FF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE7080", Offset = "0x1AE6280", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001701")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE7160", Offset = "0x1AE6360", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001702")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000324")]
	private class MarginRightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700051A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001706")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000518")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7460", Offset = "0x1AE6660", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001704")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000519")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7490", Offset = "0x1AE6690", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001705")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001709")]
		public MarginRightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001706")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7460", Offset = "0x1AE6660", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001704")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7490", Offset = "0x1AE6690", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001705")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE72A0", Offset = "0x1AE64A0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001707")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE7380", Offset = "0x1AE6580", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001708")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000325")]
	private class MarginTopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700051D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600170C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700051B")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7680", Offset = "0x1AE6880", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600170A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700051C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE76B0", Offset = "0x1AE68B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600170B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600170F")]
		public MarginTopProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600170C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7680", Offset = "0x1AE6880", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600170A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE76B0", Offset = "0x1AE68B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600170B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE74C0", Offset = "0x1AE66C0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600170D")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE75A0", Offset = "0x1AE67A0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600170E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000326")]
	private class MaxHeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000520")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001712")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700051E")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE78A0", Offset = "0x1AE6AA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001710")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700051F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE78D0", Offset = "0x1AE6AD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001711")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001715")]
		public MaxHeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001712")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE78A0", Offset = "0x1AE6AA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001710")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE78D0", Offset = "0x1AE6AD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001711")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE76E0", Offset = "0x1AE68E0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001713")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE77C0", Offset = "0x1AE69C0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001714")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000327")]
	private class MaxWidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000523")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001718")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000521")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7AC0", Offset = "0x1AE6CC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001716")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000522")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7AF0", Offset = "0x1AE6CF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001717")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600171B")]
		public MaxWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001718")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7AC0", Offset = "0x1AE6CC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001716")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7AF0", Offset = "0x1AE6CF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001717")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE7900", Offset = "0x1AE6B00", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001719")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE79E0", Offset = "0x1AE6BE0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600171A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000328")]
	private class MinHeightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000526")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600171E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000524")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7CE0", Offset = "0x1AE6EE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600171C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000525")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7D10", Offset = "0x1AE6F10", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600171D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001721")]
		public MinHeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600171E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7CE0", Offset = "0x1AE6EE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600171C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7D10", Offset = "0x1AE6F10", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600171D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE7B20", Offset = "0x1AE6D20", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600171F")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE7C00", Offset = "0x1AE6E00", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001720")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000329")]
	private class MinWidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000529")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001724")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000527")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE7F00", Offset = "0x1AE7100", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001722")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000528")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE7F30", Offset = "0x1AE7130", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001723")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001727")]
		public MinWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001724")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE7F00", Offset = "0x1AE7100", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001722")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE7F30", Offset = "0x1AE7130", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001723")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE7D40", Offset = "0x1AE6F40", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001725")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE7E20", Offset = "0x1AE7020", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001726")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200032A")]
	private class OpacityProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x1700052C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600172A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700052A")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE8080", Offset = "0x1AE7280", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001728")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700052B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE80B0", Offset = "0x1AE72B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001729")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600172D")]
		public OpacityProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600172A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE8080", Offset = "0x1AE7280", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001728")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE80B0", Offset = "0x1AE72B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001729")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE7FD0", Offset = "0x1AE71D0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600172B")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE8020", Offset = "0x1AE7220", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600172C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200032B")]
	private class OverflowProperty : InlineStyleEnumProperty<Overflow>
	{

		[Token(Token = "0x1700052F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001730")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700052D")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE82A0", Offset = "0x1AE74A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600172E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700052E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE82D0", Offset = "0x1AE74D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600172F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AE8260", Offset = "0x1AE7460", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001733")]
		public OverflowProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001730")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE82A0", Offset = "0x1AE74A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600172E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE82D0", Offset = "0x1AE74D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600172F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE80E0", Offset = "0x1AE72E0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001731")]
		public virtual StyleEnum<Overflow> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE81A0", Offset = "0x1AE73A0", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001732")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Overflow> value) { }

	}

	[Token(Token = "0x200032C")]
	private class PaddingBottomProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000532")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001736")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000530")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE84C0", Offset = "0x1AE76C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001734")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000531")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE84F0", Offset = "0x1AE76F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001735")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001739")]
		public PaddingBottomProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001736")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE84C0", Offset = "0x1AE76C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001734")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE84F0", Offset = "0x1AE76F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001735")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE8300", Offset = "0x1AE7500", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001737")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE83E0", Offset = "0x1AE75E0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001738")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200032D")]
	private class PaddingLeftProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000535")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600173C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000533")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE86E0", Offset = "0x1AE78E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600173A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000534")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE8710", Offset = "0x1AE7910", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600173B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600173F")]
		public PaddingLeftProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600173C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE86E0", Offset = "0x1AE78E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600173A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE8710", Offset = "0x1AE7910", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600173B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE8520", Offset = "0x1AE7720", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600173D")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE8600", Offset = "0x1AE7800", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600173E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200032E")]
	private class PaddingRightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000538")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001742")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000536")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE8900", Offset = "0x1AE7B00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001740")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000537")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE8930", Offset = "0x1AE7B30", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001741")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001745")]
		public PaddingRightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001742")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE8900", Offset = "0x1AE7B00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001740")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE8930", Offset = "0x1AE7B30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001741")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE8740", Offset = "0x1AE7940", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001743")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE8820", Offset = "0x1AE7A20", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001744")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x200032F")]
	private class PaddingTopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x1700053B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001748")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000539")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE8B20", Offset = "0x1AE7D20", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001746")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700053A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE8B50", Offset = "0x1AE7D50", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001747")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600174B")]
		public PaddingTopProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001748")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE8B20", Offset = "0x1AE7D20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001746")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE8B50", Offset = "0x1AE7D50", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001747")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE8960", Offset = "0x1AE7B60", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001749")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE8A40", Offset = "0x1AE7C40", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600174A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000330")]
	private class PositionProperty : InlineStyleEnumProperty<Position>
	{

		[Token(Token = "0x1700053E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600174E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700053C")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE8D40", Offset = "0x1AE7F40", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600174C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700053D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE8D70", Offset = "0x1AE7F70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600174D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AE8D00", Offset = "0x1AE7F00", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001751")]
		public PositionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600174E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE8D40", Offset = "0x1AE7F40", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600174C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE8D70", Offset = "0x1AE7F70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600174D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE8B80", Offset = "0x1AE7D80", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600174F")]
		public virtual StyleEnum<Position> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE8C40", Offset = "0x1AE7E40", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001750")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Position> value) { }

	}

	[Token(Token = "0x2000331")]
	private class RightProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000541")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001754")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700053F")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE96C0", Offset = "0x1AE88C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001752")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000540")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE96F0", Offset = "0x1AE88F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001753")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001757")]
		public RightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001754")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE96C0", Offset = "0x1AE88C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001752")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE96F0", Offset = "0x1AE88F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001753")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE9500", Offset = "0x1AE8700", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001755")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE95E0", Offset = "0x1AE87E0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001756")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000332")]
	private class RotateProperty : InlineStyleRotateProperty
	{

		[Token(Token = "0x17000544")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600175A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000542")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE98A0", Offset = "0x1AE8AA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001758")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000543")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE98D0", Offset = "0x1AE8AD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001759")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AE9890", Offset = "0x1AE8A90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleRotateProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600175D")]
		public RotateProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600175A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE98A0", Offset = "0x1AE8AA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001758")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE98D0", Offset = "0x1AE8AD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001759")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE9720", Offset = "0x1AE8920", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600175B")]
		public virtual StyleRotate GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE97A0", Offset = "0x1AE89A0", Length = "0xE0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600175C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleRotate value) { }

	}

	[Token(Token = "0x2000333")]
	private class ScaleProperty : InlineStyleScaleProperty
	{

		[Token(Token = "0x17000547")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001760")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000545")]
		public virtual string Name
		{
			[Address(RVA = "0x1AE9AD0", Offset = "0x1AE8CD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600175E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000546")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AE9B00", Offset = "0x1AE8D00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600175F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AE9AC0", Offset = "0x1AE8CC0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleScaleProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001763")]
		public ScaleProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001760")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AE9AD0", Offset = "0x1AE8CD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600175E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AE9B00", Offset = "0x1AE8D00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600175F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE9900", Offset = "0x1AE8B00", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001761")]
		public virtual StyleScale GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE99E0", Offset = "0x1AE8BE0", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001762")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleScale value) { }

	}

	[Token(Token = "0x2000334")]
	private class TextOverflowProperty : InlineStyleEnumProperty<TextOverflow>
	{

		[Token(Token = "0x1700054A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001766")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000548")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEA070", Offset = "0x1AE9270", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001764")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000549")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEA0A0", Offset = "0x1AE92A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001765")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEA030", Offset = "0x1AE9230", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001769")]
		public TextOverflowProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001766")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEA070", Offset = "0x1AE9270", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001764")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEA0A0", Offset = "0x1AE92A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001765")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AE9EB0", Offset = "0x1AE90B0", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001767")]
		public virtual StyleEnum<TextOverflow> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AE9F70", Offset = "0x1AE9170", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001768")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflow> value) { }

	}

	[Token(Token = "0x2000335")]
	private class TextShadowProperty : InlineStyleTextShadowProperty
	{

		[Token(Token = "0x1700054D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600176C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700054B")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEA2A0", Offset = "0x1AE94A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600176A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700054C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEA2D0", Offset = "0x1AE94D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600176B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEA290", Offset = "0x1AE9490", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleTextShadowProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600176F")]
		public TextShadowProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600176C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEA2A0", Offset = "0x1AE94A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600176A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEA2D0", Offset = "0x1AE94D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600176B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEA0D0", Offset = "0x1AE92D0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600176D")]
		public virtual StyleTextShadow GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEA1B0", Offset = "0x1AE93B0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600176E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTextShadow value) { }

	}

	[Token(Token = "0x2000336")]
	private class TopProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000550")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001772")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700054E")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEB380", Offset = "0x1AEA580", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001770")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700054F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEB3B0", Offset = "0x1AEA5B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001771")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001775")]
		public TopProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001772")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEB380", Offset = "0x1AEA580", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001770")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEB3B0", Offset = "0x1AEA5B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001771")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEB1C0", Offset = "0x1AEA3C0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001773")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEB2A0", Offset = "0x1AEA4A0", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001774")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000337")]
	private class TransformOriginProperty : InlineStyleTransformOriginProperty
	{

		[Token(Token = "0x17000553")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001778")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000551")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEB540", Offset = "0x1AEA740", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001776")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000552")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEB570", Offset = "0x1AEA770", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001777")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEB530", Offset = "0x1AEA730", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleTransformOriginProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600177B")]
		public TransformOriginProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001778")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEB540", Offset = "0x1AEA740", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001776")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEB570", Offset = "0x1AEA770", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001777")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEB3E0", Offset = "0x1AEA5E0", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001779")]
		public virtual StyleTransformOrigin GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEB450", Offset = "0x1AEA650", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600177A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTransformOrigin value) { }

	}

	[Token(Token = "0x2000338")]
	private class TransitionDelayProperty : InlineStyleListProperty<TimeValue>
	{

		[Token(Token = "0x17000556")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600177E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000554")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEB780", Offset = "0x1AEA980", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600177C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000555")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEB7B0", Offset = "0x1AEA9B0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600177D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEB740", Offset = "0x1AEA940", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<TimeValue>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001781")]
		public TransitionDelayProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600177E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEB780", Offset = "0x1AEA980", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600177C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEB7B0", Offset = "0x1AEA9B0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600177D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEB5A0", Offset = "0x1AEA7A0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600177F")]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEB670", Offset = "0x1AEA870", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001780")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	[Token(Token = "0x2000339")]
	private class TransitionDurationProperty : InlineStyleListProperty<TimeValue>
	{

		[Token(Token = "0x17000559")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001784")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000557")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEB9C0", Offset = "0x1AEABC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001782")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000558")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEB9F0", Offset = "0x1AEABF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001783")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEB980", Offset = "0x1AEAB80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<TimeValue>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001787")]
		public TransitionDurationProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001784")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEB9C0", Offset = "0x1AEABC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001782")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEB9F0", Offset = "0x1AEABF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001783")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEB7E0", Offset = "0x1AEA9E0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001785")]
		public virtual StyleList<TimeValue> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEB8B0", Offset = "0x1AEAAB0", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001786")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<TimeValue> value) { }

	}

	[Token(Token = "0x200033A")]
	private class TransitionPropertyProperty : InlineStyleListProperty<StylePropertyName>
	{

		[Token(Token = "0x1700055C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600178A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700055A")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEBC00", Offset = "0x1AEAE00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001788")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700055B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEBC30", Offset = "0x1AEAE30", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001789")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEBBC0", Offset = "0x1AEADC0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<StylePropertyName>", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600178D")]
		public TransitionPropertyProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600178A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEBC00", Offset = "0x1AEAE00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001788")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEBC30", Offset = "0x1AEAE30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001789")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEBA20", Offset = "0x1AEAC20", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600178B")]
		public virtual StyleList<StylePropertyName> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEBAF0", Offset = "0x1AEACF0", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600178C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<StylePropertyName> value) { }

	}

	[Token(Token = "0x200033B")]
	private class TransitionTimingFunctionProperty : InlineStyleListProperty<EasingFunction>
	{

		[Token(Token = "0x1700055F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001790")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700055D")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEBE40", Offset = "0x1AEB040", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600178E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700055E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEBE70", Offset = "0x1AEB070", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600178F")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEBE00", Offset = "0x1AEB000", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001793")]
		public TransitionTimingFunctionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001790")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEBE40", Offset = "0x1AEB040", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600178E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEBE70", Offset = "0x1AEB070", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600178F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEBC60", Offset = "0x1AEAE60", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001791")]
		public virtual StyleList<EasingFunction> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEBD30", Offset = "0x1AEAF30", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001792")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleList<EasingFunction> value) { }

	}

	[Token(Token = "0x200033C")]
	private class TranslateProperty : InlineStyleTranslateProperty
	{

		[Token(Token = "0x17000562")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001796")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000560")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEC020", Offset = "0x1AEB220", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001794")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000561")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEC050", Offset = "0x1AEB250", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001795")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEC010", Offset = "0x1AEB210", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleTranslateProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001799")]
		public TranslateProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001796")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEC020", Offset = "0x1AEB220", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001794")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEC050", Offset = "0x1AEB250", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001795")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEBEA0", Offset = "0x1AEB0A0", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001797")]
		public virtual StyleTranslate GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEBF20", Offset = "0x1AEB120", Length = "0xE0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001798")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTranslate value) { }

	}

	[Token(Token = "0x200033D")]
	private class UnityBackgroundImageTintColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000565")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600179C")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000563")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEC520", Offset = "0x1AEB720", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600179A")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000564")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEC550", Offset = "0x1AEB750", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600179B")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600179F")]
		public UnityBackgroundImageTintColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600179C")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEC520", Offset = "0x1AEB720", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600179A")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEC550", Offset = "0x1AEB750", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600179B")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEC360", Offset = "0x1AEB560", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600179D")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEC440", Offset = "0x1AEB640", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600179E")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200033E")]
	private class UnityEditorTextRenderingModeProperty : InlineStyleEnumProperty<EditorTextRenderingMode>
	{

		[Token(Token = "0x17000568")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017A2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000566")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEC740", Offset = "0x1AEB940", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017A0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000567")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEC770", Offset = "0x1AEB970", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017A1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEC700", Offset = "0x1AEB900", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017A5")]
		public UnityEditorTextRenderingModeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEC740", Offset = "0x1AEB940", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017A0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEC770", Offset = "0x1AEB970", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017A1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEC580", Offset = "0x1AEB780", Length = "0xBC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017A3")]
		public virtual StyleEnum<EditorTextRenderingMode> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEC640", Offset = "0x1AEB840", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017A4")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<EditorTextRenderingMode> value) { }

	}

	[Token(Token = "0x2000340")]
	private class UnityFontDefinitionProperty : InlineStyleFontDefinitionProperty
	{

		[Token(Token = "0x1700056E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017AE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700056C")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEC970", Offset = "0x1AEBB70", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017AC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700056D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEC9A0", Offset = "0x1AEBBA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017AD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEC960", Offset = "0x1AEBB60", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontDefinitionProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017B1")]
		public UnityFontDefinitionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017AE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEC970", Offset = "0x1AEBB70", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017AC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEC9A0", Offset = "0x1AEBBA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017AD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEC7A0", Offset = "0x1AEB9A0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017AF")]
		public virtual StyleFontDefinition GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEC880", Offset = "0x1AEBA80", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017B0")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFontDefinition value) { }

	}

	[Token(Token = "0x200033F")]
	private class UnityFontProperty : InlineStyleFontProperty
	{

		[Token(Token = "0x1700056B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017A8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000569")]
		public virtual string Name
		{
			[Address(RVA = "0x1AECB90", Offset = "0x1AEBD90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017A6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700056A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AECBC0", Offset = "0x1AEBDC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017A7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AECB80", Offset = "0x1AEBD80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFontProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017AB")]
		public UnityFontProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017A8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AECB90", Offset = "0x1AEBD90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017A6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AECBC0", Offset = "0x1AEBDC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017A7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEC9D0", Offset = "0x1AEBBD0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017A9")]
		public virtual StyleFont GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AECAA0", Offset = "0x1AEBCA0", Length = "0xD0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017AA")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFont value) { }

	}

	[Token(Token = "0x2000341")]
	private class UnityFontStyleAndWeightProperty : InlineStyleEnumProperty<FontStyle>
	{

		[Token(Token = "0x17000571")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017B4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700056F")]
		public virtual string Name
		{
			[Address(RVA = "0x1AECDC0", Offset = "0x1AEBFC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017B2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000570")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AECDF0", Offset = "0x1AEBFF0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017B3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AECD80", Offset = "0x1AEBF80", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017B7")]
		public UnityFontStyleAndWeightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017B4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AECDC0", Offset = "0x1AEBFC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017B2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AECDF0", Offset = "0x1AEBFF0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017B3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AECBF0", Offset = "0x1AEBDF0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017B5")]
		public virtual StyleEnum<FontStyle> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AECCB0", Offset = "0x1AEBEB0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017B6")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<FontStyle> value) { }

	}

	[Token(Token = "0x2000342")]
	private class UnityOverflowClipBoxProperty : InlineStyleEnumProperty<OverflowClipBox>
	{

		[Token(Token = "0x17000574")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017BA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000572")]
		public virtual string Name
		{
			[Address(RVA = "0x1AECFF0", Offset = "0x1AEC1F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017B8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000573")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED020", Offset = "0x1AEC220", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017B9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AECFB0", Offset = "0x1AEC1B0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017BD")]
		public UnityOverflowClipBoxProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017BA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AECFF0", Offset = "0x1AEC1F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017B8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED020", Offset = "0x1AEC220", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017B9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AECE20", Offset = "0x1AEC020", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017BB")]
		public virtual StyleEnum<OverflowClipBox> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AECEE0", Offset = "0x1AEC0E0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017BC")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<OverflowClipBox> value) { }

	}

	[Token(Token = "0x2000343")]
	private class UnityParagraphSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x17000577")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017C0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000575")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED210", Offset = "0x1AEC410", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017BE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000576")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED240", Offset = "0x1AEC440", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017BF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C3")]
		public UnityParagraphSpacingProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED210", Offset = "0x1AEC410", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017BE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED240", Offset = "0x1AEC440", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017BF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED050", Offset = "0x1AEC250", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017C1")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED130", Offset = "0x1AEC330", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017C2")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000344")]
	private class UnitySliceBottomProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x1700057A")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017C6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000578")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED330", Offset = "0x1AEC530", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017C4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000579")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED360", Offset = "0x1AEC560", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017C5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AED320", Offset = "0x1AEC520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleIntProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C9")]
		public UnitySliceBottomProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017C6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED330", Offset = "0x1AEC530", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017C4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED360", Offset = "0x1AEC560", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017C5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED270", Offset = "0x1AEC470", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017C7")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED2C0", Offset = "0x1AEC4C0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017C8")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000345")]
	private class UnitySliceLeftProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x1700057D")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017CC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700057B")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED440", Offset = "0x1AEC640", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017CA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700057C")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED470", Offset = "0x1AEC670", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017CB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AED320", Offset = "0x1AEC520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleIntProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017CF")]
		public UnitySliceLeftProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017CC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED440", Offset = "0x1AEC640", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017CA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED470", Offset = "0x1AEC670", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017CB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED390", Offset = "0x1AEC590", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017CD")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED3E0", Offset = "0x1AEC5E0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017CE")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000346")]
	private class UnitySliceRightProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x17000580")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017D2")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700057E")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED550", Offset = "0x1AEC750", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017D0")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700057F")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED580", Offset = "0x1AEC780", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017D1")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AED320", Offset = "0x1AEC520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleIntProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017D5")]
		public UnitySliceRightProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017D2")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED550", Offset = "0x1AEC750", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017D0")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED580", Offset = "0x1AEC780", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017D1")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED4A0", Offset = "0x1AEC6A0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017D3")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED4F0", Offset = "0x1AEC6F0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017D4")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000347")]
	private class UnitySliceScaleProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000583")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017D8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000581")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED660", Offset = "0x1AEC860", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017D6")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000582")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED690", Offset = "0x1AEC890", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017D7")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DB")]
		public UnitySliceScaleProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017D8")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED660", Offset = "0x1AEC860", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017D6")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED690", Offset = "0x1AEC890", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017D7")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED5B0", Offset = "0x1AEC7B0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017D9")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED600", Offset = "0x1AEC800", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017DA")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x2000348")]
	private class UnitySliceTopProperty : InlineStyleIntProperty
	{

		[Token(Token = "0x17000586")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017DE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000584")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED770", Offset = "0x1AEC970", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017DC")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000585")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED7A0", Offset = "0x1AEC9A0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017DD")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AED320", Offset = "0x1AEC520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleIntProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E1")]
		public UnitySliceTopProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017DE")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED770", Offset = "0x1AEC970", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017DC")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED7A0", Offset = "0x1AEC9A0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017DD")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED6C0", Offset = "0x1AEC8C0", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017DF")]
		public virtual StyleInt GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED710", Offset = "0x1AEC910", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017E0")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleInt value) { }

	}

	[Token(Token = "0x2000349")]
	private class UnitySliceTypeProperty : InlineStyleEnumProperty<SliceType>
	{

		[Token(Token = "0x17000589")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017E4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000587")]
		public virtual string Name
		{
			[Address(RVA = "0x1AED9A0", Offset = "0x1AECBA0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017E2")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000588")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AED9D0", Offset = "0x1AECBD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017E3")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AED960", Offset = "0x1AECB60", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017E7")]
		public UnitySliceTypeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017E4")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AED9A0", Offset = "0x1AECBA0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017E2")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AED9D0", Offset = "0x1AECBD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017E3")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AED7D0", Offset = "0x1AEC9D0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017E5")]
		public virtual StyleEnum<SliceType> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AED890", Offset = "0x1AECA90", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017E6")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<SliceType> value) { }

	}

	[Token(Token = "0x200034A")]
	private class UnityTextAlignProperty : InlineStyleEnumProperty<TextAnchor>
	{

		[Token(Token = "0x1700058C")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017EA")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700058A")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEDBD0", Offset = "0x1AECDD0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017E8")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700058B")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEDC00", Offset = "0x1AECE00", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017E9")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEDB90", Offset = "0x1AECD90", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017ED")]
		public UnityTextAlignProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017EA")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEDBD0", Offset = "0x1AECDD0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017E8")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEDC00", Offset = "0x1AECE00", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017E9")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEDA00", Offset = "0x1AECC00", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017EB")]
		public virtual StyleEnum<TextAnchor> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEDAC0", Offset = "0x1AECCC0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017EC")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextAnchor> value) { }

	}

	[Token(Token = "0x200034B")]
	private class UnityTextAutoSizeProperty : InlineStyleTextAutoSizeProperty
	{

		[Token(Token = "0x1700058F")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700058D")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEDD90", Offset = "0x1AECF90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017EE")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700058E")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEDDC0", Offset = "0x1AECFC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017EF")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEDD80", Offset = "0x1AECF80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleTextAutoSizeProperty", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017F3")]
		public UnityTextAutoSizeProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F0")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEDD90", Offset = "0x1AECF90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017EE")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEDDC0", Offset = "0x1AECFC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017EF")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEDC30", Offset = "0x1AECE30", Length = "0x6D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002B8E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60017F1")]
		public virtual StyleTextAutoSize GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEDCA0", Offset = "0x1AECEA0", Length = "0xDB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017F2")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleTextAutoSize value) { }

	}

	[Token(Token = "0x200034C")]
	private class UnityTextGeneratorProperty : InlineStyleEnumProperty<TextGeneratorType>
	{

		[Token(Token = "0x17000592")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017F6")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000590")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEDFC0", Offset = "0x1AED1C0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017F4")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000591")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEDFF0", Offset = "0x1AED1F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017F5")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEDF80", Offset = "0x1AED180", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x60017F9")]
		public UnityTextGeneratorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017F6")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEDFC0", Offset = "0x1AED1C0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017F4")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEDFF0", Offset = "0x1AED1F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017F5")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEDDF0", Offset = "0x1AECFF0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60017F7")]
		public virtual StyleEnum<TextGeneratorType> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEDEB0", Offset = "0x1AED0B0", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017F8")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextGeneratorType> value) { }

	}

	[Token(Token = "0x200034D")]
	private class UnityTextOutlineColorProperty : InlineStyleColorProperty
	{

		[Token(Token = "0x17000595")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x60017FC")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000593")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEE1E0", Offset = "0x1AED3E0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017FA")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000594")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEE210", Offset = "0x1AED410", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x60017FB")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD2F80", Offset = "0x1AD2180", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleColorProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FF")]
		public UnityTextOutlineColorProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60017FC")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEE1E0", Offset = "0x1AED3E0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017FA")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEE210", Offset = "0x1AED410", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60017FB")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEE020", Offset = "0x1AED220", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017FD")]
		public virtual StyleColor GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEE100", Offset = "0x1AED300", Length = "0xD7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60017FE")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleColor value) { }

	}

	[Token(Token = "0x200034E")]
	private class UnityTextOutlineWidthProperty : InlineStyleFloatProperty
	{

		[Token(Token = "0x17000598")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001802")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000596")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEE2F0", Offset = "0x1AED4F0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001800")]
			 get { } //Length: 44
		}

		[Token(Token = "0x17000597")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEE320", Offset = "0x1AED520", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001801")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD52E0", Offset = "0x1AD44E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleFloatProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001805")]
		public UnityTextOutlineWidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001802")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEE2F0", Offset = "0x1AED4F0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001800")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEE320", Offset = "0x1AED520", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001801")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEE240", Offset = "0x1AED440", Length = "0x48")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001803")]
		public virtual StyleFloat GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEE290", Offset = "0x1AED490", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C330")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001804")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleFloat value) { }

	}

	[Token(Token = "0x200034F")]
	private class UnityTextOverflowPositionProperty : InlineStyleEnumProperty<TextOverflowPosition>
	{

		[Token(Token = "0x1700059B")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001808")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000599")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEE520", Offset = "0x1AED720", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001806")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700059A")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEE550", Offset = "0x1AED750", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001807")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEE4E0", Offset = "0x1AED6E0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x600180B")]
		public UnityTextOverflowPositionProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001808")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEE520", Offset = "0x1AED720", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001806")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEE550", Offset = "0x1AED750", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001807")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEE350", Offset = "0x1AED550", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001809")]
		public virtual StyleEnum<TextOverflowPosition> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEE410", Offset = "0x1AED610", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600180A")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<TextOverflowPosition> value) { }

	}

	[Token(Token = "0x2000350")]
	private class VisibilityProperty : InlineStyleEnumProperty<Visibility>
	{

		[Token(Token = "0x1700059E")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600180E")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700059C")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEE860", Offset = "0x1AEDA60", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600180C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x1700059D")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEE890", Offset = "0x1AEDA90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600180D")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEE820", Offset = "0x1AEDA20", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001811")]
		public VisibilityProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600180E")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEE860", Offset = "0x1AEDA60", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600180C")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEE890", Offset = "0x1AEDA90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600180D")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEE690", Offset = "0x1AED890", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600180F")]
		public virtual StyleEnum<Visibility> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEE750", Offset = "0x1AED950", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001810")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<Visibility> value) { }

	}

	[Token(Token = "0x2000351")]
	private class WhiteSpaceProperty : InlineStyleEnumProperty<WhiteSpace>
	{

		[Token(Token = "0x170005A1")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001814")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700059F")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEEA90", Offset = "0x1AEDC90", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001812")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A0")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEEAC0", Offset = "0x1AEDCC0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001813")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AEEA50", Offset = "0x1AEDC50", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleEnumProperty`1", Member = ".ctor", ReturnType = typeof(void))]
		[Token(Token = "0x6001817")]
		public WhiteSpaceProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001814")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEEA90", Offset = "0x1AEDC90", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001812")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEEAC0", Offset = "0x1AEDCC0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001813")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEE8C0", Offset = "0x1AEDAC0", Length = "0xBE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6001815")]
		public virtual StyleEnum<WhiteSpace> GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEE980", Offset = "0x1AEDB80", Length = "0xC5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001816")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleEnum<WhiteSpace> value) { }

	}

	[Token(Token = "0x2000352")]
	private class WidthProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170005A4")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x600181A")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005A2")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEECB0", Offset = "0x1AEDEB0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001818")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A3")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEECE0", Offset = "0x1AEDEE0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x6001819")]
			 get { } //Length: 44
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600181D")]
		public WidthProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600181A")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEECB0", Offset = "0x1AEDEB0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001818")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEECE0", Offset = "0x1AEDEE0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6001819")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEEAF0", Offset = "0x1AEDCF0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600181B")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEEBD0", Offset = "0x1AEDDD0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600181C")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[Token(Token = "0x2000353")]
	private class WordSpacingProperty : InlineStyleLengthProperty
	{

		[Token(Token = "0x170005A7")]
		public virtual bool IsReadOnly
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001820")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005A5")]
		public virtual string Name
		{
			[Address(RVA = "0x1AEEED0", Offset = "0x1AEE0D0", Length = "0x2C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Token(Token = "0x600181E")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170005A6")]
		public virtual string ussName
		{
			[Address(RVA = "0x1AEEF00", Offset = "0x1AEE100", Length = "0x36A")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
			[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
			[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
			[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
			[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
			[Token(Token = "0x600181F")]
			 get { } //Length: 874
		}

		[Address(RVA = "0x1AD4FA0", Offset = "0x1AD41A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleLengthProperty", Member = ".ctor", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001823")]
		public WordSpacingProperty() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001820")]
		public virtual bool get_IsReadOnly() { }

		[Address(RVA = "0x1AEEED0", Offset = "0x1AEE0D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600181E")]
		public virtual string get_Name() { }

		[Address(RVA = "0x1AEEF00", Offset = "0x1AEE100", Length = "0x36A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(VisualElement), Member = "get_hasDefaultRotationAndScale", ReturnType = typeof(bool))]
		[Calls(Type = typeof(VisualElement), Member = "GetPivotedMatrixWithLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Bounds)}, ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(VisualElement), Member = "ResolveTranslate", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(VisualElement), Member = "get_layout", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(VisualElement), Member = "CalculateConservativeRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4&), typeof(Rect)}, ReturnType = typeof(Rect))]
		[Token(Token = "0x600181F")]
		public virtual string get_ussName() { }

		[Address(RVA = "0x1AEED10", Offset = "0x1AEDF10", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001821")]
		public virtual StyleLength GetValue(ref InlineStyleAccess container) { }

		[Address(RVA = "0x1AEEDF0", Offset = "0x1AEDFF0", Length = "0xD9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001822")]
		public virtual void SetValue(ref InlineStyleAccess container, StyleLength value) { }

	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C2B")]
	private readonly List<IProperty`1<InlineStyleAccess>> m_PropertiesList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C2C")]
	private readonly Dictionary<String, IProperty`1<InlineStyleAccess>> m_PropertiesHash; //Field offset: 0x20

	[Address(RVA = "0x1ADB150", Offset = "0x1ADA350", Length = "0x17F3")]
	[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFloat), typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFloat, System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleRotate), typeof(Rotate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleRotate, UnityEngine.UIElements.Rotate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleScaleProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleScale), typeof(Scale)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleScale, UnityEngine.UIElements.Scale>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleTextShadowProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextShadow), typeof(TextShadow)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTextShadow, UnityEngine.UIElements.TextShadow>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleTransformOriginProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTransformOrigin), typeof(TransformOrigin)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTransformOrigin, UnityEngine.UIElements.TransformOrigin>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<UnityEngine.UIElements.TimeValue>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.TimeValue>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleListProperty`1<UnityEngine.UIElements.StylePropertyName>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleListProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleRotateProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.EasingFunction>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleTranslateProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTranslate), typeof(Translate)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTranslate, UnityEngine.UIElements.Translate>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleFontProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFont), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFont, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleFontDefinitionProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleFontDefinition), typeof(FontDefinition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleFontDefinition, UnityEngine.UIElements.FontDefinition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleIntProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleInt), typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleInt, System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleList`1<UnityEngine.UIElements.StylePropertyName>, System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleCursor), typeof(Cursor)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleCursor, UnityEngine.UIElements.Cursor>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleTextAutoSize), typeof(TextAutoSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleTextAutoSize, UnityEngine.UIElements.TextAutoSize>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleTextAutoSizeProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleEnumProperty`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStyleValue", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<TStyleValue, TValue>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleColorProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleCursorProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleColor), typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleColor, UnityEngine.Color>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackground), typeof(Background)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackground, UnityEngine.UIElements.Background>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleBackgroundPositionProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition), typeof(BackgroundPosition)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundPosition, UnityEngine.UIElements.BackgroundPosition>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleBackgroundRepeatProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundRepeat), typeof(BackgroundRepeat)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundRepeat, UnityEngine.UIElements.BackgroundRepeat>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleBackgroundSizeProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundSize), typeof(BackgroundSize)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleBackgroundSize, UnityEngine.UIElements.BackgroundSize>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleLengthProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleAccessPropertyBag), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleLength), typeof(Length)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.InlineStyleAccessPropertyBag+InlineStyleProperty`2<UnityEngine.UIElements.StyleLength, UnityEngine.UIElements.Length>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleFloatProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlineStyleBackgroundProperty), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6001621")]
	public InlineStyleAccessPropertyBag() { }

	[Address(RVA = "0x6E5820", Offset = "0x6E4A20", Length = "0x17B")]
	[CalledBy(Type = typeof(InlineStyleAccessPropertyBag), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001622")]
	private void AddProperty(InlineStyleProperty<TStyleValue, TValue> property) { }

	[Address(RVA = "0x1ADB020", Offset = "0x1ADA220", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001623")]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties() { }

	[Address(RVA = "0x1ADB080", Offset = "0x1ADA280", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<IProperty`1<TContainer>>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6001624")]
	public virtual PropertyCollection<InlineStyleAccess> GetProperties(ref InlineStyleAccess container) { }

	[Address(RVA = "0x1ADB0E0", Offset = "0x1ADA2E0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001625")]
	public override bool TryGetProperty(ref InlineStyleAccess container, string name, out IProperty<InlineStyleAccess>& property) { }

}

