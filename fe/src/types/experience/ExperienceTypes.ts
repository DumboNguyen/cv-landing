import type { BaseEntity } from '../common/BaseTypes';

export interface Experience extends BaseEntity {
  title: string;
  company: string;
  location: string;
  startDate: Date;
  endDate?: Date;
  isCurrent: boolean;
  description: string;
  achievements: string[];
  technologies: string[];
}
