using System.Collections.Generic;

namespace SixPack.CodeGen
{
	/// <summary>
	/// A class that implements AbstractClass by simply storing data.
	/// </summary>
	public class SimpleClass: AbstractClass
	{
		private readonly List<AbstractConstructor> constructors = new List<AbstractConstructor>();
		private readonly List<AbstractField> fields = new List<AbstractField>();
		private readonly List<AbstractMethod> methods = new List<AbstractMethod>();
		private readonly List<AbstractProperty> properties = new List<AbstractProperty>();
		private readonly List<AbstractUsingClause> usingClauses = new List<AbstractUsingClause>();
		private string name;
		private AbstractNamespace namespaceDefinition;
		private string postfix;
		private string prefix;

		/// <summary>
		/// Initializes a new instance of the <see cref="SimpleClass"/> class.
		/// </summary>
		protected SimpleClass()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SimpleClass"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="namespace">The name space.</param>
		public SimpleClass(string name, AbstractNamespace @namespace): this(name, @namespace, string.Empty)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SimpleClass"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="namespace">The name space.</param>
		/// <param name="prefix">The prefix.</param>
		public SimpleClass(string name, AbstractNamespace @namespace, string prefix)
			: this(name, @namespace, prefix, string.Empty)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SimpleClass"/> class.
		/// </summary>
		/// <param name="name">The name.</param>
		/// <param name="namespace">The name space.</param>
		/// <param name="prefix">The prefix.</param>
		/// <param name="postfix">The postfix.</param>
		public SimpleClass(string name, AbstractNamespace @namespace, string prefix, string postfix)
		{
			this.name = name;
			this.postfix = postfix;
			this.prefix = prefix;
			namespaceDefinition = @namespace;
		}

		/// <summary>
		/// Gets the fields.
		/// </summary>
		/// <value>The fields.</value>
		public override ICollection<AbstractField> Fields
		{
			get { return fields; }
		}

		/// <summary>
		/// Gets the properties.
		/// </summary>
		/// <value>The properties.</value>
		public override ICollection<AbstractProperty> Properties
		{
			get { return properties; }
		}

		/// <summary>
		/// Gets the methods.
		/// </summary>
		/// <value>The methods.</value>
		public override ICollection<AbstractMethod> Methods
		{
			get { return methods; }
		}

		/// <summary>
		/// Gets the constructors.
		/// </summary>
		/// <value>The constructors.</value>
		public override ICollection<AbstractConstructor> Constructors
		{
			get { return constructors; }
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public override string Name
		{
			get { return name; }
			protected set { name = value; }
		}

		/// <summary>
		/// Gets or sets the prefix.
		/// </summary>
		/// <value>The prefix.</value>
		public override string Prefix
		{
			get { return prefix; }
			protected set { prefix = value; }
		}

		/// <summary>
		/// Gets or sets the postfix.
		/// </summary>
		/// <value>The postfix.</value>
		public override string Postfix
		{
			get { return postfix; }
			protected set { postfix = value; }
		}

		/// <summary>
		/// Gets or sets the name space.
		/// </summary>
		/// <value>The name space.</value>
		public override AbstractNamespace NamespaceDefinition
		{
			get { return namespaceDefinition; }
			protected set { namespaceDefinition = value; }
		}

		/// <summary>
		/// Gets the using clauses.
		/// </summary>
		/// <value>The using clauses.</value>
		public override ICollection<AbstractUsingClause> UsingClauses
		{
			get { return usingClauses; }
		}
	}
}