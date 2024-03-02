using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        
        public class WorkoutRoutine
        {
            public string Name { get; set; }
            public List<Exercise> Exercises { get; set; }

            public WorkoutRoutine(string name)
            {
                Name = name;
                Exercises = new List<Exercise>();
            }

            public void AddExercise(Exercise exercise)
            {
                Exercises.Add(exercise);
            }
        }

        class Program
        {
            static void Main()
            {
                Set set1 = new Set(10, 50);
                Set set2 = new Set(12, 55);

                Exercise exercise1 = new Exercise("Push-ups");
                exercise1.AddSet(set1);
                exercise1.AddSet(set2);

                Exercise exercise2 = new Exercise("Squats");
                exercise2.AddSet(new Set(15, 60));

                WorkoutRoutine routine = new WorkoutRoutine("Full Body Workout");
                routine.AddExercise(exercise1);
                routine.AddExercise(exercise2);

                Console.WriteLine($"Workout Routine: {routine.Name}");
                foreach (var exercise in routine.Exercises)
                {
                    Console.WriteLine($"Exercise: {exercise.Name}");
                    foreach (var set in exercise.Sets)
                    {
                        Console.WriteLine($"- Repetitions: {set.Repetitions}, Weight: {set.Weight} lbs");
                    }
                    Console.WriteLine();
                }
            }
        }

    }
}
}
