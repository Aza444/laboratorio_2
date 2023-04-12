using System;
using System.Collections.Generic;

namespace Laboratorio_2.Models;

public partial class Nota
{
    public int IdNotas { get; set; }

    public string Materia { get; set; } = null!;

    public string NombreEstudiante { get; set; } = null!;

    public decimal Lab_1 { get; set; }

    public decimal Parcial_1 { get; set; }

    public decimal Lab_2 { get; set; }

    public decimal Parcial_2 { get; set; }

    public decimal Lab_3 { get; set; }

    public decimal Parcial_3 { get; set; }

    public decimal Resultado { get; set; }
}
