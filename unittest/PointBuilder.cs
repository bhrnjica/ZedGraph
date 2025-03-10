namespace ZedGraph
{
    using System.Drawing;
    using AutoFixture.Kernel;
    

    internal class PointBuilder : ISpecimenBuilder
    {
        #region Methods

        public object Create(object request, ISpecimenContext context)
        {
          if (!typeof(Point).Equals(request))
            return new NoSpecimen();
          var x = (int)context.Resolve(typeof(int));
          var y = (int)context.Resolve(typeof(int));
          return new Point(x, y);
        }

        #endregion
    }
}
