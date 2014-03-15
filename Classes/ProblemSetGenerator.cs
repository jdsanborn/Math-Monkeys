/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: ProblemSetGenerator , and abstract class
 * -has the properties needed for a new Problem set, this are 
 *      -rangeBottom, _rangeTop, _numberOfProblems, _goal, _attemptsPerProblem each with its own getter and setter
 *  public abstract void GenerateProblem()- will be overriden later in new problem set such addition, and subtraction.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Math_Monkeys
{
    //Coder of this class - Mary Venegas
    public abstract class ProblemSetGenerator
    {
        //Private Properties from problemSetGenerator interface
        protected int _rangeBottom;
        protected int _rangeTop;
        protected int _numberOfProblems;
        protected int _goal;
        protected int _attemptsPerProblem;
        

        // Fields definition
        public int RangeBottom
        {
            get
            {
                return _rangeBottom;
            }
            set
            {
                _rangeBottom = value;
            }
        } // Allowed min: -100, max: 99
        public int RangeTop
        {
            get
            {
                return _rangeTop;
            }
            set
            {
                _rangeTop = value;
            }
        }   // Allowed min: -99, max: 100
        public int NumberOfProblems
        {
            get
            {
                return _numberOfProblems;
            }
            set
            {
                _numberOfProblems = value;
               /* if (_numberOfProblems > 1 && _numberOfProblems < 21)
                {
                    //ok
                }
                else
                {
                    _numberOfProblems = 10;
                    //setting it to default 
                }*/
            }
        } // Allowed min: 1, max: 20
        public int Goal
        {
            get
            {
                return _goal;
            }
            set
            {
                _goal = value;
            }
        } // Allowed min: 1, max: NumberOfProblems
        public int AttemptsPerProblem
        {
            get
            {
                return _attemptsPerProblem;
            }
            set
            {
                _attemptsPerProblem = value;
            }
        } // Allowed min: 1, max 10

    
        // Additional requirement: RangeTop > RangeBottom at all times
    
        public abstract void GenerateProblem();// called by GetNext; take care of generation and storage
   
    }
}
