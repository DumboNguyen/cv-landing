import React from 'react';
import { BarChart, Bar, XAxis, YAxis, CartesianGrid, Tooltip, ResponsiveContainer, Cell } from 'recharts';
import { skillsChartData } from '../../../data';
import './SkillsChart.css';

const SkillsChart: React.FC = () => {
  return (
    <div className="skills-chart">
      <ResponsiveContainer width="100%" height={250}>
        <BarChart
          layout="vertical"
          data={skillsChartData}
          margin={{ top: 20, right: 30, left: 20, bottom: 20 }}
        >
          <CartesianGrid strokeDasharray="3 3" />
          <XAxis type="number" domain={[0, 100]} tickFormatter={(tick) => `${tick}%`} />
          <YAxis dataKey="name" type="category" />
          <Tooltip formatter={(value) => `${value}%`} />
          <Bar
            dataKey="value"
            barSize={20}
            radius={[5, 5, 5, 5]}
          >
            {skillsChartData.map((entry, index) => (
              <Cell key={`cell-${index}`} fill={entry.color} />
            ))}
          </Bar>
        </BarChart>
      </ResponsiveContainer>
    </div>
  );
};

export default SkillsChart;
