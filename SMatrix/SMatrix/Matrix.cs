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

    }
}