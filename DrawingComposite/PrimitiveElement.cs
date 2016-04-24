using System;
namespace DrawingComposite {
	class PrimitiveElement:DrawingElement {
		//C'tor
		public PrimitiveElement(string name):base(name){}
		public override void Add(DrawingElement d) {
			Console.WriteLine("Cannot add to a PrimitiveElement");
		}

		public override void Remove(DrawingElement d) {
			Console.WriteLine("Cannot remove from a PrimitiveElement");
		}

		public override void Display(int indent) {
			Console.WriteLine(new String('-',indent)+" "+_name);
		}
	}
}