namespace TimePayroll.Entities.Enums;

// Виды проектов компании
public enum ProjectType
{
    // Обозначает отсутствие выбранного типа проекта
    None = 0,
    
    // Обозначает сопровождение готовой системы
    SystemSupport = 1,

    // Обозначает разработку собственного продукта
    OwnProductDevelopment = 2
}
