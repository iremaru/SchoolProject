# Readme

## Objectives

1. Make a program to manage a small school.
2. Manage students according to their grade.
3. Manage subjects.
4. Manage evaluations.
5. Create reports.

## Entities

- School
  - Dirección
    - CargosDirectivos
    - JefaturaDeEstudios
    - Departamento (Director de departamento. Asignaturas)
    - Profesorado
      - Profesor
  - Alumnado => Student Body
    - Alumno
  - Academic Term
  - Clase (Curso | Grupo | Promoción) => Class (SchoolGrade | Group | Year)
    - Promoción
      - Curso (Plan de estudios | Grupos)
        - Grupos
  - CurriculumEscolar => School curriculum
    - Curso (SchoolGrade)
      - Subject
    - Asignatura
      - Plan de estudios
      - Examen
        - Pregunta
          - Enunciado
          - Respuesta

