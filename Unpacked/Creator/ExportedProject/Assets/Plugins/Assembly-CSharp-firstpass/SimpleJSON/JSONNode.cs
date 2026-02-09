using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace SimpleJSON
{
	public abstract class JSONNode
	{
		public struct Enumerator
		{
			private enum Type
			{
				None = 0,
				Array = 1,
				Object = 2
			}

			private Type type;

			private Dictionary<string, JSONNode>.Enumerator m_Object;

			private List<JSONNode>.Enumerator m_Array;

			public bool IsValid => false;

			public KeyValuePair<string, JSONNode> Current => default(KeyValuePair<string, JSONNode>);

			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				type = default(Type);
				m_Object = default(Dictionary<string, JSONNode>.Enumerator);
				m_Array = default(List<JSONNode>.Enumerator);
			}

			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				type = default(Type);
				m_Object = default(Dictionary<string, JSONNode>.Enumerator);
				m_Array = default(List<JSONNode>.Enumerator);
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public struct ValueEnumerator
		{
			private Enumerator m_Enumerator;

			public JSONNode Current => null;

			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				m_Enumerator = default(Enumerator);
			}

			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				m_Enumerator = default(Enumerator);
			}

			public ValueEnumerator(Enumerator aEnumerator)
			{
				m_Enumerator = default(Enumerator);
			}

			public bool MoveNext()
			{
				return false;
			}

			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		public struct KeyEnumerator
		{
			private Enumerator m_Enumerator;

			public JSONNode Current => null;

			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
				m_Enumerator = default(Enumerator);
			}

			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
				m_Enumerator = default(Enumerator);
			}

			public KeyEnumerator(Enumerator aEnumerator)
			{
				m_Enumerator = default(Enumerator);
			}

			public bool MoveNext()
			{
				return false;
			}

			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			private JSONNode m_Node;

			private Enumerator m_Enumerator;

			public KeyValuePair<string, JSONNode> Current => default(KeyValuePair<string, JSONNode>);

			object IEnumerator.Current => null;

			internal LinqEnumerator(JSONNode aNode)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}

			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			public void Reset()
			{
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_Children_003Ed__39 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			JSONNode IEnumerator<JSONNode>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_Children_003Ed__39(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_DeepChildren_003Ed__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private JSONNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public JSONNode _003C_003E4__this;

			private IEnumerator<JSONNode> _003C_003E7__wrap1;

			private IEnumerator<JSONNode> _003C_003E7__wrap2;

			JSONNode IEnumerator<JSONNode>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_DeepChildren_003Ed__41(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static bool forceASCII;

		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		public static JSONContainerType VectorContainerType;

		public static JSONContainerType QuaternionContainerType;

		public static JSONContainerType RectContainerType;

		public abstract JSONNodeType Tag { get; }

		public virtual JSONNode this[int aIndex]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual JSONNode this[string aKey]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual int Count => 0;

		public virtual bool IsNumber => false;

		public virtual bool IsString => false;

		public virtual bool IsBoolean => false;

		public virtual bool IsNull => false;

		public virtual bool IsArray => false;

		public virtual bool IsObject => false;

		public virtual bool Inline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual IEnumerable<JSONNode> Children
		{
			[IteratorStateMachine(typeof(_003Cget_Children_003Ed__39))]
			get
			{
				return null;
			}
		}

		public IEnumerable<JSONNode> DeepChildren
		{
			[IteratorStateMachine(typeof(_003Cget_DeepChildren_003Ed__41))]
			get
			{
				return null;
			}
		}

		public IEnumerable<KeyValuePair<string, JSONNode>> Linq => null;

		public KeyEnumerator Keys => default(KeyEnumerator);

		public ValueEnumerator Values => default(ValueEnumerator);

		public virtual double AsDouble
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public virtual int AsInt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public virtual float AsFloat
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public virtual bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual JSONArray AsArray => null;

		public virtual JSONObject AsObject => null;

		internal static StringBuilder EscapeBuilder => null;

		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		public virtual void Add(JSONNode aItem)
		{
		}

		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(int aIndent)
		{
			return null;
		}

		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		public abstract Enumerator GetEnumerator();

		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		public static implicit operator double(JSONNode d)
		{
			return 0.0;
		}

		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		public static implicit operator float(JSONNode d)
		{
			return 0f;
		}

		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		public static implicit operator int(JSONNode d)
		{
			return 0;
		}

		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		public static implicit operator bool(JSONNode d)
		{
			return false;
		}

		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		public static bool operator ==(JSONNode a, object b)
		{
			return false;
		}

		public static bool operator !=(JSONNode a, object b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal static string Escape(string aText)
		{
			return null;
		}

		private static void ParseElement(JSONNode ctx, string token, string tokenName, bool quoted)
		{
		}

		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		public Rect ReadRect()
		{
			return default(Rect);
		}

		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		public RectOffset ReadRectOffset()
		{
			return null;
		}

		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}
	}
}
