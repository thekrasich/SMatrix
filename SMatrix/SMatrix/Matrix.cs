namespace SMatrix
{
    public class Matrix
    {
        public double[,] elemenents = new double[0,0];

        #region Fillers

        /// <summary>
        /// Fills Matrix sized nxm with given nubmer.
        /// </summary>
        /// <param name="n">Nubmer of rows </param>
        /// <param name="m">Number of columns.</param>
        /// <param name="number"></param>
        public void FillWithNumber(int  n, int m, double number)
        {
            elemenents = new double[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    elemenents[i,j] = number;
                }
            }
        }
        /// <summary>
        /// Create a Identity matrix with size of nxn.
        /// </summary>
        /// <param name="n">Size of matrix.</param>
        public void FillIdentityMatrix(int n)
        {
            elemenents = new double[n, n];
            for (int i = 0;i < n; i++)
            {
                elemenents[i, i] = 1;
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
            elemenents =new double[n,m];
            elemenents[i, j] = 1;
        }

        #endregion

        #region Addition

        /// <summary>
        /// Add matrix to another matrix.
        /// </summary>
        public void AddMatrix(Matrix obj)
        {
            if (elemenents.GetLength(0) != obj.elemenents.GetLength(0) || elemenents.GetLength(1) != obj.elemenents.GetLength(1))
            { 
                throw new InvalidOperationException("Cannot add two matrixes with different sizes."); 
            }
            else
            {
                for (int i = 0; i < elemenents.GetLength(0); i++)
                {
                    for (int j = 0; j < elemenents.GetLength(1); j++)
                    {
                        this.elemenents[i, j] += obj.elemenents[i, j];
                    }
                }
            }
        }

        /// <summary>
        /// Add number to matrix.
        /// </summary>
        /// <param name="number">Number that will be added.</param>
        public void AddNumber(double number)
        {
            for (int i = 0; i < elemenents.GetLength(0); i++)
            {
                for (int j = 0; j < elemenents.GetLength(1); j++)
                {
                    this.elemenents[i, j] += number;
                }
            }
        }

        #endregion

        #region Difference
        /// <summary>
        /// Subtract the matrix.
        /// </summary>
        public void SubtractMatrix(Matrix obj)
        {
            if (elemenents.GetLength(0) != obj.elemenents.GetLength(0) || elemenents.GetLength(1) != obj.elemenents.GetLength(1))
            {
                throw new InvalidOperationException("Cannot substract two matrixes with different sizes.");
            }
            else
            {
                for (int i = 0; i < elemenents.GetLength(0); i++)
                {
                    for (int j = 0; j < elemenents.GetLength(1); j++)
                    {
                        this.elemenents[i, j] -= obj.elemenents[i, j];
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
            for (int i = 0; i < elemenents.GetLength(0); i++)
            {
                for (int j = 0; j < elemenents.GetLength(1); j++)
                {
                    this.elemenents[i, j] -= number;
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
            double[,] clone = new double[elemenents.GetLength(0), elemenents.GetLength(1)];

            for (int i = 0; i < elemenents.GetLength(0); i++)
            {
                for (int j = 0; j < elemenents.GetLength(1); j++)
                {
                    clone[i, j] = elemenents[i, j];
                }
            }

            elemenents = new double[clone.GetLength(1), clone.GetLength(0)];

            for (int i = 0; i < elemenents.GetLength(0); i++)
            {
                for (int j = 0; j < elemenents.GetLength(1); j++)
                {
                    elemenents[i, j] = clone[j, i];
                }
            }

        }
        #endregion
    }
}