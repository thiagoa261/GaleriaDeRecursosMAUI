using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GaleriaDeRecursos2.Models;
using GaleriaDeRecursos2.Views.Cels;
using GaleriaDeRecursos2.Views.Components;
using GaleriaDeRecursos2.Views.Forms;
using GaleriaDeRecursos2.Views.Layouts;
using GaleriaDeRecursos2.Views.Visuals;

namespace GaleriaDeRecursos2.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "StackLayout",
                        Description = "Organização sequencial vertical dos elementos.",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Posiciona e dimensiona os " +
                        "elementos de forma abosluta.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos" +
                        "de forma personalizada.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });

            categories.Add(new Category()
            {
                Name = "Componentes",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Um componente que cria uma" +
                        "caixa ou área na tela",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Adiciona um rótulo à tela",
                        Page = typeof(LabelPage)
                    },
                    new Component
                    {
                        Title = "Button",
                        Description = "Adiciona um botão na tela",
                        Page = typeof(ButtonPage)
                    },
                    new Component
                    {
                        Title = "Image",
                        Description = "Adiciona uma imagem na tela",
                        Page = typeof(ImagePage)
                    },
                    new Component
                    {
                        Title = "Image Button",
                        Description = "Adiciona uma imagem na tela " +
                        "com comportamentos de botão",
                        Page = typeof(ImageButtonPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component> { 
                    new Component {
                        Title = "Frame",
                        Description = "Caixa que envolve outros" +
                        "elementos",
                        Page = typeof(FramePage)
                    },
                    new Component {
                        Title = "Shadow",
                        Description = "Adiciona sombra ao elemento",
                        Page = typeof(ShadowPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Formulários",
                Components = new List<Component> {
                    new Component {
                        Title = "Entry/Editor",
                        Description = "Inputs de Texto, com uma ou" +
                        "múltiplas linhas",
                        Page = typeof(EntryPage)
                    },
                    new Component {
                        Title = "CheckBox",
                        Description = "Campo para marcar ou desmarcar uma opção",
                        Page = typeof(CheckBoxPage)
                    },
                    new Component {
                        Title = "RadioButton",
                        Description = "Seleciona um, entre dois ou" +
                        "mais itens",
                        Page = typeof(RadioButtonPage)
                    },
                    new Component {
                        Title = "Switch",
                        Description = "Interruptor, ativa ou" +
                        "desativa uma opção",
                        Page = typeof(SwitchPage)
                    },
                    new Component {
                        Title = "Stepper",
                        Description = "Incrementa ou decrementa um" +
                        "número",
                        Page = typeof(StepperPage)
                    },
                    new Component {
                        Title = "Slider",
                        Description = "Barra de seleção para um ponto " +
                        "em um intervalo",
                        Page = typeof(SliderPage)
                    },
                    new Component {
                        Title = "TimePicker",
                        Description = "Seleção de hora e minuto",
                        Page = typeof(TimePickerPage)
                    },
                    new Component {
                        Title = "DatePicker",
                        Description = "Seleção de data",
                        Page = typeof(DatePickerPage)
                    },
                    new Component {
                        Title = "Picker",
                        Description = "Seleciona um item em uma lista (dropdown)",
                        Page = typeof(PickerPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Células",
                Components = new List<Component> {
                    new Component {
                        Title = "TextCell",
                        Description = "Apresenta até dois labels (titulo + descrição)",
                        Page = typeof(CelText)
                    },
                    new Component {
                        Title = "ImageCell",
                        Description = "Apresenta uma imagem com dois labels",
                        Page = typeof(ImageCel)
                    },
                    new Component {
                        Title = "SwitchCell",
                        Description = "Apresenta um switch junto a um label",
                        Page = typeof(SwitchCellPage)
                    },
                    new Component {
                        Title = "EntryCell",
                        Description = "Apresenta um campo de texto com label",
                        Page = typeof(EntryCellPage)
                    },
                    new Component {
                        Title = "ViewCell",
                        Description = "cria uma celula com design perosnalizado",
                        Page = typeof(ViewCellPage)
                    }
                }
            });
            return categories;
        }
    }
}
