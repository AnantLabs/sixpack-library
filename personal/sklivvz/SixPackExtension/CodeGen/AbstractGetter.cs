using System.Collections.Generic;

namespace SixPack.CodeGen
{
	/// <summary>
	/// An abstract accessor class that represents a getter
	/// </summary>
	public abstract class AbstractGetter: IAbstractAccessor, IClassElement
	{
		#region IAbstractAccessor Members

		/// <summary>
		/// Gets the body.
		/// </summary>
		/// <value>The body.</value>
		public abstract ICollection<string> Body { get; }

		/// <summary>
		/// Gets the prefix.
		/// </summary>
		/// <value>The prefix.</value>
		public abstract string Prefix { get; }

		#endregion

		#region IClassElement Members

		/// <summary>
		/// Accepts the specified visitor.
		/// </summary>
		/// <param name="visitor">The visitor.</param>
		public void Accept(IClassVisitor visitor)
		{
			if (visitor != null)
				visitor.Visit(this);
		}

		#endregion
	}
}