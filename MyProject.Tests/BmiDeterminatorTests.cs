﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyProject.Tests
{
    public class BmiDeterminatorTests
    {
        [Theory]
        [InlineData(10.0)]
        [InlineData(19.0)]
        [InlineData(18.0)]
        [InlineData(8.0)]

        public void DetermineBmi_ForBmiBelow18_5_ReturnsUnderweightClassification(double bmi)
        {
            // arrange

            BmiDeterminator bmiDeterminator = new BmiDeterminator();

            // act 


            BmiClassification result = bmiDeterminator.DetermineBmi(bmi);

            // assert

            Assert.Equal(BmiClassification.Underweight, result);



            
        }
    }
}
