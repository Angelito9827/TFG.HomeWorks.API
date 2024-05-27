using TFG.HomeWorks.Application.Exceptions.Base;

namespace TFG.HomeWorks.Application.Exceptions
{
    public enum CustomApplicationExceptionCode
    {
        /// <summary>
        /// No usar
        /// </summary>
        /// <remarks>Se aplica automáticamente a las excepciones de validación de FluentValidation mediante el middleware de control de excepciones</remarks>
        [CustomApplicationExceptionCodeMessage("Error de validación")]
        [Obsolete("No usar. Se establece automáticamente al lanzar validaciones con FluentValidation")]
        ValidationException = 1_001,

        #region Auth 2_XXX

        [CustomApplicationExceptionCodeMessage("Usuario o contraseña no válido")]
        Auth_InvalidUserOrPassword = 2_001,

        [CustomApplicationExceptionCodeMessage("El Email ya ha sido registrado")]
        Auth_UserExist = 2_002,

        [CustomApplicationExceptionCodeMessage("Rol no válido")]
        Auth_InvalidRole = 2_003,

        [CustomApplicationExceptionCodeMessage("Usuario/a no encontrado")]
        Auth_UserNotFound = 2_004,

        #endregion Auth 2_XXX

        #region CustomerNavision 3_XXX

        [CustomApplicationExceptionCodeMessage("Usuario de Navision no encontrado")]
        Customernavision_NotFound = 3_001,

        #endregion CustomerNavision 3_XXX




        #region Test 999_XXX

        [CustomApplicationExceptionCodeMessage("Se ha violado una regla de negocio de pruebas cualquiera")]
        Test_AnyBusinessRuleViolation = 999_001,

        #endregion Test 999_XXX


    }
}

