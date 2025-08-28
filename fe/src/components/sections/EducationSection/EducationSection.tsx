import React from 'react';
import Card from '../../common/Card/Card';
import { educationData } from '../../../data';
import './EducationSection.css';

const EducationSection: React.FC = () => {
  const formatDate = (date: Date) => {
    return date.toLocaleDateString('en-US', { month: 'short', year: 'numeric' });
  };

  const formatDateRange = (startDate: Date, endDate?: Date, isCurrent?: boolean) => {
    const start = formatDate(startDate);
    if (isCurrent) {
      return `${start} – Present`;
    }
    if (endDate) {
      return `${start} – ${formatDate(endDate)}`;
    }
    return start;
  };

  return (
    <div className="container-education">
      <div className="container-education-header">
        <span>Education</span>
      </div>
      <div className="container-education-content">
        {educationData.map((education) => (
          <Card key={education.id} className="container-education-card" hoverable>
            <div className="container-education-card-title">
              <span>{education.degree}</span>
            </div>
            <div className="container-education-card-subtitle">
              <span>
                {education.institution}, {education.location} | {formatDateRange(education.startDate, education.endDate, education.isCurrent)}
              </span>
            </div>
            <div className="container-education-card-detail">
              <span>{education.description}</span>
            </div>
            {education.gpa && (
              <div className="container-education-card-gpa">
                <span>GPA: {education.gpa}</span>
              </div>
            )}
          </Card>
        ))}
      </div>
    </div>
  );
};

export default EducationSection;
