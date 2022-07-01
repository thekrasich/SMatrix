namespace SMatrix
{
    public class Matrix
    {
        public double[,] elements = new double[0,0];

        #region Fillers

        /// <summary>
        /// Fills Matrix sized nxm with given nubmer.
        /// </summary>
        /// <param name="n">Nubmer of rows </param>
        /// <param name="m">Number of columns.</param>
        /// <param name="number"></param>
        public void FillWithNumber(int  n, int m, double number)
        {
            elements = new double[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    elements[i,j] = number;
                }
            }
        }
        /// <summary>
        /// Create a Identity matrix with size of nxn.
        /// </summary>
        /// <param name="n">Size of matrix.</param>
        public void FillIdentityMatrix(int n)
        {
            elements = new double[n, n];
            for (int i = 0;i < n; i++)
            {
                elements[i, i] = 1;
            }
        }
        /// <summary>
        /// Create a Matrix Unit. 
        /// </summary>
        /// <param name="i">Row position.</param>
        /// <param name="j">Coloumn position.</param>
        /// <param name="n">Nubmer of rows </param>
        /// <param name="m">Number of columns.</param>
        public void FillMatrixUnit(int i , int j, int n , int m)
        {
            elements =new double[n,m];
            elements[i, j] = 1;
        }

        #endregion

        #region Addition

        /// <summary>
        /// Add matrix to another matrix.
        /// </summary>
        public void AddMatrix(Matrix obj)
        {
            if (elements.GetLength(0) != obj.elements.GetLength(0) || elements.GetLength(1) != obj.elements.GetLength(1))
            { 
                throw new InvalidOperationException("Cannot add two matrixes with different sizes."); 
            }
            else
            {
                for (int i = 0; i < elements.GetLength(0); i++)
                {
                    for (int j = 0; j < elements.GetLength(1); j++)
                    {
                        this.elements[i, j] += obj.elements[i, j];
                    }
                }
            }
        }

        /// <summary>
        /// Add number to all elements in matrix.
        /// </summary>
        /// <param name="number">Number that will be added.</param>
        public void AddNumber(double number)
        {
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    this.elements[i, j] += number;
                }
            }
        }

        /// <summary>
        /// Add number to the specific element in matrix.
        /// </summary>
        /// <param name="number">Number that will be added.</param>
        /// <param name="i">Row position of the element.</param>
        /// <param name="j">Column position of the element.</param>
        public void AddNumberSpecific(double number, int i, int j)
        {
            this.elements[i, j] += number;
        }

        #endregion

        #region Difference
        /// <summary>
        /// Subtract the matrix.
        /// </summary>
        public void SubtractMatrix(Matrix obj)
        {
            if (elements.GetLength(0) != obj.elements.GetLength(0) || elements.GetLength(1) != obj.elements.GetLength(1))
            {
                throw new InvalidOperationException("Cannot substract two matrixes with different sizes.");
            }
            else
            {
                for (int i = 0; i < elements.GetLength(0); i++)
                {
                    for (int j = 0; j < elements.GetLength(1); j++)
                    {
                        this.elements[i, j] -= obj.elements[i, j];
                    }
                }
            }
        }
        /// <summary>
        /// Subtract number from matrix.
        /// </summary>
        /// <param name="number">Number that will be subtracted.</param>
        public void SubtractNumber(double number)
        {
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    this.elements[i, j] -= number;
                }
            }
        }
        #endregion

        #region Transition
        /// <summary>
        /// Transpose the matrix.
        /// </summary>
        public void Transition()
        {
            double[,] clone = new double[elements.GetLength(0), elements.GetLength(1)];

            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    clone[i, j] = elements[i, j];
                }
            }

            elements = new double[clone.GetLength(1), clone.GetLength(0)];

            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    elements[i, j] = clone[j, i];
                }
            }

        }
        #endregion

        #region ConsoleCommands
        /// <summary>
        /// Print matrix in console.
        /// </summary>
        public void ConsoleOutput()
        {
            for (int i = 0; i < elements.GetLength(0); i++, Console.WriteLine("\n"))
            {
                for (int j = 0; j < elements.GetLength(1); j++, Console.Write("\t"))
                {
                    Console.Write(elements[i, j]);
                }
            }
        }
        /// <summary>
        /// Input matrix from console.
        /// </summary>
        public void ConsoleInput()
        {
            Console.WriteLine("Enter number of rows");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            int numberOfCols = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    Console.WriteLine($"Enter element at position [{i},{j}]: ");
                    elements[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }    
        }
        #endregion

        #region Multiplication
        /// <summary>
        /// Multiplies every element of matrix by given number.
        /// </summary>
        /// <param name="number"></param>
        public void MultiplyByNumber(double number)
        {
            for (int i = 0; i <elements.GetLength(0) ; i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    elements[i, j] *= number;
                }
            }
        }
        #endregion

        #region Division by a scalar
        /// <summary>
        /// Divides all elements by specific number.
        /// </summary>
        /// <param name="scalar">Number that the matrix is divided by.</param>
        public void DivisionByScalar(double scalar)
        {
            for (int i = 0; i < elements.GetLength(0); i++)
            {
                for (int j = 0; j < elements.GetLength(1); j++)
                {
                    this.elements[i, j] /= scalar;
                }
            }
        }


        #endregion
    }
}