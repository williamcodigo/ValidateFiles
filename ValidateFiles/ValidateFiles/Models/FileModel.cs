namespace ValidateFiles.Models
{
    /// <summary>
    /// Modelo file (archivo) el cual almacena propiedades de un archivo
    /// </summary>
    public class FileModel
    {

        #region Atributos
        /// <summary>
        /// Almacena el nombre del archivo
        /// </summary>
        private string _fileName = string.Empty;
        #endregion

        #region Constructores

        #region Constructor
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public FileModel()
        {

        }// Constructor
        #endregion

        #endregion

        #region Propiedades

        #region FileName
        /// <summary>
        /// Obtiene o establece el nombre del archivo
        /// </summary>
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }// FileName
        #endregion

        #endregion

    }// Clase
}// Namespace