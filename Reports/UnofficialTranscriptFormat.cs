using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestin.Reports
{
    /// <summary>
    /// Class <c>UnofficialTranscriptFormat</c> Clase usada para almacenar el formato usado para crear actas volantes
    /// </summary>
    internal class UnofficialTranscriptFormat
    {
        string header = @"
            <div style='width:auto; float:left; height:auto;'>
                <h3 style='margin:0px'>Instituto Superior de Formación Técnica N° 194</h3>
            </div>
            <div style='width: auto;float:right;  height:auto;'>
                <h4 style='float:right; margin: 0px;margin-right:10%'>Código: @ExamId</h4>
            </div>
            <h5 style='margin: 2px;margin-right:3%;text-align:right'>Libro: ____Folio: ___</h5>
            ";
        string title = @"
            <div style='width:100%;'>
                <h1 style='text-align: center; padding-top: 0px;'>Acta volante de examen</h1>
            </div>";
string info = @"
    <div style='height:auto; width:100%'>
        <div style='width:70%; float:left;padding-top=10%'>
            <h5>CARRERA: @career</h5>
            <h5>MATERIA: @subject</h5>
            <h5>DOCENTE: @titular</h5>
            <h5>VOCALES: @vowels</h5>
        </div>
        <div style='width: auto;float:right'>
            <h5>AÑO: @yearInCareer° año</h5>
            <h5>FECHA: @date</h5>
            <h5>LUGAR: @place</h5>
            <h5>MODALIDAD: Examen final</h5>
        </div>
    </div>";
        string table = @"
            <div style='padding:1px;'>
                 <table style='border: 1px solid black; border-collapse: collapse; width:100%'>
                    <tr style='border: 1px solid black;border-collapse: collapse;'>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>N°</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Apellido y nombre</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Dni</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Condición</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Escrito</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Oral</td>
                        <td style='border: 1px solid black;border-collapse: collapse;margin:5px;font-weight: bold'>Nota final</td>
                    </tr>

";
        string sign = @"
                </table>
            </div>
            <div style='text-align:left;width:100%;padding-top: 50px'>
                <div style='width:auto; float:left; height:auto;padding-right: 20px'>
                    <h4 style='display: inline;'>Presidente __________________</h4>
                </div>
                <div style='width:auto; float:left; height:auto;padding-right: 20px'>
                    <h4 style='display: inline;'>Vocal __________________</h4>
                </div>
                <div style='width:auto; float:left; height:auto;'>
                    <h4 style='display: inline;'>Vocal __________________</h4>
                </div>
            </div>";
        string data = @"
            <div style='text-align:center;item-align:center;padding-top: 30px;width:100%'>
                <div style='width:auto; float:right; height:auto;padding-left: 20px;padding-right: 60px'>
                    <h4 style='display: inline;'>Ausentes: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;padding-left: 20px'>
                    <h4 style='display: inline;'>Desaprobados: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;padding-left: 20px'>
                    <h4 style='display: inline;'>Aprobados: ____</h4>
                </div>
                <div style='width:auto; float:right; height:auto;'>
                    <h4 style='display: inline;'>Total de alumnos: ____</h4>
                </div>
            </div>";
        public string getHeader() { return header; }
        public string getInfo() { return info; }
        public string getTitle() { return title; }
        public string getTable() { return table; }
        public string getSign() { return sign; }
        public string getData() { return data; }
    }
}
