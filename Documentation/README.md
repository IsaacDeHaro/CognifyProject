## Documentación Técnica

Los siguientes diagramas UML describen la arquitectura y el flujo del sistema Cognify:

### 1. Diagrama de Clases
![Diagrama de Clases](https://github.com/IsaacDeHaro/CognifyProject/blob/main/Documentation/UML/Cognify_Diagrama_Clases.png)

### 2. Diagrama de Secuencia
![Diagrama de Secuencia](https://github.com/IsaacDeHaro/CognifyProject/blob/main/Documentation/UML/Cognify_Diagrama_Secuencia.png)

### 3. Diagrama de Casos de Uso
![Diagrama de Casos de Uso](https://github.com/IsaacDeHaro/CognifyProject/blob/main/Documentation/UML/Cognify_Diagrama_Casos_De_Uso.png)

---

### **Análisis del Impacto Social y Técnico del Sistema Cognify**

---

#### **Impacto Social**

1. **Rehabilitación Ética y Humanitaria:**
   - Cognify plantea un cambio radical en la manera de abordar el sistema penal, eliminando el enfoque punitivo y priorizando la rehabilitación ética. Esto puede generar comunidades más inclusivas y reducir el estigma social hacia los ex-reclusos.
   - Los recuerdos implantados permiten a los criminales experimentar empatía y arrepentimiento, lo que fomenta un cambio genuino en su comportamiento.

2. **Reducción de la Reincidencia:**
   - Al utilizar simulaciones personalizadas basadas en el tipo de crimen, Cognify aborda directamente las causas psicológicas del comportamiento delictivo, disminuyendo las probabilidades de reincidencia.

3. **Optimización de Recursos Sociales:**
   - La eliminación o reducción de infraestructura carcelaria permite redirigir fondos a sectores clave como educación, salud e infraestructura pública.
   - Las comunidades se benefician al reintegrar rápidamente a los ex-criminales como ciudadanos productivos.

4. **Controversia y Consideraciones Éticas:**
   - Aunque Cognify prioriza la rehabilitación, algunos sectores podrían cuestionar la ética de manipular recuerdos y emociones humanas, lo que requerirá un marco legal sólido y ético para su implementación.

---

#### **Impacto Técnico**

1. **Innovación Tecnológica:**
   - Cognify incorpora técnicas avanzadas como mapeo cerebral, inteligencia artificial y moduladores emocionales. Aunque esta implementación es simulada en consola, la arquitectura modular permite su expansión hacia entornos reales más complejos.

2. **Eficiencia y Escalabilidad:**
   - El uso del patrón MVC asegura que el sistema sea altamente modular. Esto facilita agregar nuevas características (nuevos tipos de crímenes, emociones, o configuraciones) sin afectar significativamente otras partes del sistema.
   - La separación de responsabilidades (Modelo, Vista y Controlador) mejora la mantenibilidad del sistema.

3. **Patrones de Diseño:**
   - El uso de patrones creacionales como **Factory Method** y **Builder** proporciona flexibilidad en la creación y personalización de recuerdos. Esto asegura que el sistema pueda adaptarse fácilmente a diferentes tipos de crímenes y objetivos de rehabilitación.
   - La implementación del patrón **Singleton** para configuraciones globales garantiza un control centralizado y evita conflictos en configuraciones compartidas.

4. **Simulaciones Personalizadas:**
   - El sistema permite la personalización de simulaciones según el tipo de crimen, el nivel de peligrosidad y la motivación del criminal. Esto asegura un enfoque específico y efectivo para cada usuario.

5. **Limitaciones Técnicas:**
   - El sistema actual es un prototipo funcional en consola, lo que limita su aplicabilidad en entornos reales. La integración con hardware de mapeo cerebral y tecnologías de realidad virtual será necesaria para llevar Cognify a su máximo potencial.

---

#### **Pruebas y Resultados Simulados**

1. **Descripción del Propósito**
   - Esta sección presenta los resultados de las simulaciones realizadas con el sistema Cognify. Se incluyen escenarios que abarcan distintos tipos de crímenes, métodos elegidos y niveles de arrepentimiento generados durante la simulación.

2. **Tabla de Resultados Simulados**

   ```markdown
   | Criminal | Crimen       | Método Elegido         | Nivel de Arrepentimiento (%) | Resultado Simulación                      |
   |----------|--------------|------------------------|-----------------------------|-------------------------------------------|
   | Juan     | Violento     | Rehabilitación         | 84                          | Listo para reintegrarse a la sociedad      |
   | María    | Financiero   | Sentencia Tradicional  | N/A                         | Cumplirá su condena tradicional           |
   | Luis     | De Odio      | Rehabilitación         | 92                          | Listo para reintegrarse a la sociedad      |
   | Ana      | Violento     | Rehabilitación         | 75                          | Requiere más sesiones de rehabilitación   |
   | Pedro    | Financiero   | Rehabilitación         | 68                          | Requiere más sesiones de rehabilitación   |
   ```

3. **Análisis de Resultados**
     - Criminales con niveles de arrepentimiento superiores al 80% están listos para reintegrarse.
     - Criminales con niveles menores a 80% requieren más sesiones de rehabilitación.
     - Los criminales que optaron por sentencias tradicionales no generan niveles de arrepentimiento.

4. **Conclusión de la Simulación**
     > Las pruebas demuestran que el sistema Cognify puede identificar el impacto emocional de los recuerdos implantados y determinar si un criminal está listo para reintegrarse a la sociedad. Además, se evidenció que los niveles de arrepentimiento son variables dependiendo del tipo de crimen y método elegido.

---

### **Conclusión del Análisis**

Cognify tiene un impacto transformador en el sistema penal y la sociedad, con ventajas técnicas que garantizan su escalabilidad y adaptabilidad. Sin embargo, también plantea desafíos éticos y técnicos que deberán ser abordados antes de su implementación en un entorno real.
